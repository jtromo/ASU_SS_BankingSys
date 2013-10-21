using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
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
                //Log exception here
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
                //Log exception here
                return null;
            }
        }

        public static List<Tables.DepartmentTransaction> GetDepartmentTransactionsForUser(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<DepartmentTransaction> departmentTransactions = db.DepartmentTransactions.SqlQuery("SELECT * FROM dbo.DepartmentTransactions WHERE usernameInitiated = @p0 OR usernameEffected = @p0", username).ToList();

                    if (departmentTransactions.Count() < 1)
                    {
                        return null;
                    }

                    return departmentTransactions;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public static bool MakeRoleEscalation(string usernameInitiated, string usernameEffected, int roleOld, int roleNew, string description, int? isCritical, string mustBeAuthorizedByUserName)
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

                    return true;
                }

            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }

        public static bool MakeDepartmentTransfer(int fromDepartmentId, int toDepartmentId, string usernameInitiated, string usernameEffected, string description, int? isCritical, string mustBeAuthorizedByUserName)
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

                    return true;
                }

            }
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }
    }
}