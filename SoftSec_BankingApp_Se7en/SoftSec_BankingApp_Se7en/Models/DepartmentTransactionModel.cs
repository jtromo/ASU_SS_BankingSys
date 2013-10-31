using log4net;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{

    public class DepartmentTransactionModel
    {
        public const int DEPARTMENT_TRANSFER_TYPE_ROLE_ESCALATION = 1;
        public const int DEPARTMENT_TRANSFER_TYPE_DEPT_CHANGE = 2;

        public const int DEPARTMENT_TRANSFER_STATUS_PROCESSING = 1;
        public const int DEPARTMENT_TRANSFER_STATUS_APPROVED = 2;
        public const int DEPARTMENT_TRANSFER_STATUS_REJECTED = 3;

        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

        public static DepartmentTransaction GetDepartmentTransaction(int deptTransactionId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<DepartmentTransaction> deptTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE id = @p0", deptTransactionId).ToList();

                    if (deptTransactions.Count() < 1)
                    {
                        return null;
                    }

                    DepartmentTransaction deptTransaction = deptTransactions.First();

                    if (deptTransaction == null)
                    {
                        return null;
                    }

                    return deptTransaction;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<DepartmentTransaction> GetTransactionsForDepartment(int deptId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Department> departments = db.Departments.SqlQuery("SELECT * FROM dbo.Departments WHERE id = @p0", deptId).ToList();

                    if (departments.Count() < 1)
                    {
                        return null;
                    }

                    Department department = departments.First();
                    List<DepartmentTransaction> departmentTransactions = department.DepartmentTransactions.ToList();

                    return departmentTransactions;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<Tables.DepartmentTransaction> GetDepartmentTransactionsForUser(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<DepartmentTransaction> departmentTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE ((usernameInitiated = @p0 OR usernameEffected = @p0) AND (status = @p1 AND isCritical = @p1))", username,1).ToList();

                    if (departmentTransactions.Count() < 1)
                    {
                        return null;
                    }

                    return departmentTransactions;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static int MakeRoleEscalation(string usernameInitiated, string usernameEffected, int roleOld, int roleNew, string description, int? isCritical, string mustBeAuthorizedByUserName)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    DepartmentTransaction deptTransaction = new DepartmentTransaction();
                    deptTransaction.type = DEPARTMENT_TRANSFER_TYPE_ROLE_ESCALATION;
                    deptTransaction.fromDepartmentId = null;
                    deptTransaction.toDepartmentId = null;
                    deptTransaction.usernameInitiated = usernameInitiated;
                    deptTransaction.usernameEffected = usernameEffected;
                    deptTransaction.roleOld = roleOld;
                    deptTransaction.roleNew = roleNew;
                    deptTransaction.description = description;
                    deptTransaction.status = DEPARTMENT_TRANSFER_STATUS_PROCESSING;
                    deptTransaction.isCritical = isCritical;
                    deptTransaction.mustBeAuthorizedByUserName = mustBeAuthorizedByUserName;
                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    deptTransaction.processedTime = timestamp;
                    deptTransaction.creationTime = timestamp;

                    db.DepartmentTransactions.Add(deptTransaction);
                    db.SaveChanges();

                    Tlog.Debug("User: " + usernameEffected + " role escalated successfully");

                    return deptTransaction.id;
                }

            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return -1;
            }
        }

        public static int MakeDepartmentTransfer(int fromDepartmentId, int toDepartmentId, string usernameInitiated, string usernameEffected, string description, int? isCritical, string mustBeAuthorizedByUserName)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    DepartmentTransaction deptTransaction = new DepartmentTransaction();
                    deptTransaction.type = DEPARTMENT_TRANSFER_TYPE_DEPT_CHANGE;
                    deptTransaction.fromDepartmentId = fromDepartmentId;
                    deptTransaction.toDepartmentId = toDepartmentId;
                    deptTransaction.usernameInitiated = usernameInitiated;
                    deptTransaction.usernameEffected = usernameEffected;
                    deptTransaction.roleOld = null;
                    deptTransaction.roleNew = null;
                    deptTransaction.description = description;
                    deptTransaction.status = DEPARTMENT_TRANSFER_STATUS_PROCESSING;
                    deptTransaction.isCritical = isCritical;
                    deptTransaction.mustBeAuthorizedByUserName = mustBeAuthorizedByUserName;
                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    deptTransaction.processedTime = timestamp;
                    deptTransaction.creationTime = timestamp;

                    db.DepartmentTransactions.Add(deptTransaction);
                    db.SaveChanges();

                    Tlog.Debug("User: " + usernameEffected + " department transferred successfully");

                    return deptTransaction.id;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return -1;
            }
        }

        public static bool AcceptDepartmentTransaction(int deptTransactionId)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (var db = new SSBankDBContext())
                    {
                        List<DepartmentTransaction> deptTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE id = @p0", deptTransactionId).ToList();

                        if (deptTransactions.Count() < 1)
                        {
                            return false;
                        }

                        DepartmentTransaction deptTransaction = deptTransactions.First();

                        if (deptTransaction == null)
                        {
                            return false;
                        }

                        deptTransaction.status = DEPARTMENT_TRANSFER_STATUS_APPROVED;

                        db.DepartmentTransactions.Attach(deptTransaction);
                        var vdeptTransaction = db.Entry(deptTransaction);
                        vdeptTransaction.Property(e => e.status).IsModified = true;

                        if (deptTransaction.type == DEPARTMENT_TRANSFER_TYPE_DEPT_CHANGE)
                        {
                            if (deptTransaction.usernameEffected == null)
                                return false;

                            List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", deptTransaction.usernameEffected).ToList();

                            if (users.Count() < 1)
                            {
                                return false;
                            }

                            User user = users.First();
                            if (user.departmentId != deptTransaction.fromDepartmentId)
                            {
                                // This is an error. We need to determine how to handle it
                                Console.Write("From department does not match!");
                            }

                            user.departmentId = deptTransaction.toDepartmentId;

                            db.Users.Attach(user);
                            var vdeptId = db.Entry(user);
                            vdeptId.Property(e => e.departmentId).IsModified = true;

                        }
                        else if (deptTransaction.type == DEPARTMENT_TRANSFER_TYPE_ROLE_ESCALATION)
                        {
                            if (deptTransaction.usernameEffected == null)
                                return false;

                            List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", deptTransaction.usernameEffected).ToList();

                            if (users.Count() < 1)
                            {
                                return false;
                            }

                            User user = users.First();
                            if (user.roleId != deptTransaction.roleOld)
                            {
                                // This is an error. We need to determine how to handle it
                                Console.Write("Old role does not match!");
                            }

                            user.roleId = deptTransaction.roleNew;

                            db.Users.Attach(user);
                            var vdeptId = db.Entry(user);
                            vdeptId.Property(e => e.roleId).IsModified = true;
                        }
                        else
                        {
                            return false;
                        }

                        db.SaveChanges();
                        scope.Complete();

                        Tlog.Debug("Department Transfer: " + deptTransactionId + " accepted successfully");

                        return true;
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool RejectDepartmentTransaction(int deptTransactionId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<DepartmentTransaction> deptTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE id = @p0", deptTransactionId).ToList();

                    if (deptTransactions.Count() < 1)
                    {
                        return false;
                    }

                    DepartmentTransaction deptTransaction = deptTransactions.First();

                    if (deptTransaction == null)
                    {
                        return false;
                    }

                    deptTransaction.status = DEPARTMENT_TRANSFER_STATUS_REJECTED;

                    db.DepartmentTransactions.Attach(deptTransaction);
                    var vdeptTransaction = db.Entry(deptTransaction);
                    vdeptTransaction.Property(e => e.status).IsModified = true;

                    db.SaveChanges();

                    Tlog.Debug("Department Transfer: " + deptTransactionId + " rejected successfully");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static List<DepartmentTransaction> AllRequests()
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<DepartmentTransaction> deptTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE (isCritical = @p0 AND status = @p1)", 1,1).ToList();

                    return deptTransactions;
                }
            }
            catch (Exception exp)
            {
                return null;
            }
        }
    }
}