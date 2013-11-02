using log4net;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class UserModel
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

        public static bool CreateUser(User newUser, string password, string socialSecurity, string birthdate, string checkingAccountNumber, string savingsAccountNumber, string routingNumber, Card checkingCard, Card savingsCard, Address address, List<SecurityQuestion> securityQuestions)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    if (newUser == null)
                        return false;
                    if (address == null)
                        return false;

                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    newUser.creationTime = timestamp;
                    newUser.Address = address;
                    newUser.SecurityQuestions = securityQuestions;
                    newUser.isActive = true;
                    Tables.Account checkingAccount = new Tables.Account { accountNumber=checkingAccountNumber, routingNumber=routingNumber, balance=0.0, isActive=true, accountTypeId=2, creationTime=timestamp };
                    // Add Card
                    checkingCard.accountNumber = checkingAccountNumber;
                    checkingAccount.Card = checkingCard;
                    checkingAccount.balance = 200;
                    Tables.Account savingsAccount = new Tables.Account { accountNumber = savingsAccountNumber, routingNumber = routingNumber, balance = 0.0, isActive = true, accountTypeId = 3, creationTime = timestamp };
                    //Add savings Card
                    savingsAccount.accountNumber = savingsAccountNumber;
                    savingsAccount.Card = savingsCard;
                    savingsAccount.balance = 500;
                    List<Tables.Account> accounts = new List<Tables.Account> { checkingAccount, savingsAccount };
                    newUser.Accounts = accounts;

                    // Hash generation
                    if (newUser.SetHashandSaltForPII(password, socialSecurity, birthdate))
                    {
                        //Response.Write("Valid");
                    }
                    else
                    {
                        //Response.Write("Not Valid");
                    }
                    //Create Certificate for Merchant user.
                    if (newUser.roleId == 3)
                    {
                        PkiCertificate pkRecordAvail = PkiModel.GetAvailableCertificateNames().First();
                        pkRecordAvail.username = newUser.username;
                        db.PkiCertificates.Attach(pkRecordAvail);
                        var vUsrNm = db.Entry(pkRecordAvail);
                        vUsrNm.Property(e => e.username).IsModified = true;
                    }

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    Tlog.Debug("New user: " + newUser.username + " successfully added");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);

                return false;
            }
        }

        public static bool CreateEmployee(User newUser, string password, string socialSecurity, string birthdate, Address address, List<SecurityQuestion> securityQuestions)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    if (newUser == null)
                        return false;
                    if (address == null)
                        return false;

                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    newUser.creationTime = timestamp;
                    newUser.Address = address;
                    newUser.SecurityQuestions = securityQuestions;

                    // Hash generation
                    if (newUser.SetHashandSaltForPII(password, socialSecurity, birthdate))
                    {
                        //Response.Write("Valid");
                    }
                    else
                    {
                        //Response.Write("Not Valid");
                    }
                    if (newUser.roleId == 7)
                    {
                        PkiCertificate pkRecordAvail = PkiModel.GetAvailableCertificateNames().First();
                        pkRecordAvail.username = newUser.username;
                        db.PkiCertificates.Attach(pkRecordAvail);
                        var vUsrNm = db.Entry(pkRecordAvail);
                        vUsrNm.Property(e => e.username).IsModified = true;
                    }

                    db.Users.Add(newUser);

                    Tlog.Debug("New employee: " + newUser.username + " successfully added");

                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static User GetUser(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;

                    return user;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        /// <summary>
        /// Returns the user object, given the Row ID.
        /// </summary>
        /// <param name="iuserId">Row ID</param>
        /// <returns>User Object</returns>
        public static User GetUser(int iuserId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE id = @p0", iuserId).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;

                    return user;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<User> GetUsersForDepartmentIdRoleId(int departmentId, int roleId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE departmentId = @p0 AND roleId = @p1", departmentId, roleId).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    return users;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }


        public static List<User> GetUsersForRoleId(int roleId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE roleId = @p0 ", roleId).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    return users;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static bool GetUserStatus(string iuserName)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", iuserName).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;

                    return user.isActive;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static string GetUserSessionID(string iuserName)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", iuserName).ToList();

                    if (users.Count() < 1)
                    {
                        return null;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;

                    return user.sessionId;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }


        public static bool RemoveUser(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();
                    Address address = user.Address;
                    ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;
                    db.Users.Remove(user);
                    db.SaveChanges();

                    Tlog.Debug("User: " + username + " successfully removed");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool CheckRegularAccess(string username, int departmentId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    // id 1 is invalid
                    if (departmentId < 2)
                        return false;

                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();

                    // Role 1 is invalid. 2/3 are external users. Must be at least 4 to have a department
                    if (user.roleId < 4)
                        return false;

                    if (user.departmentId == departmentId)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool CheckSuperiorAccess(string username, int departmentId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    // id 1 is invalid
                    if (departmentId < 2)
                        return false;
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();

                    // Must be role 5 or higher to have superior access
                    if (user.roleId < 5)
                        return false;

                    if (user.departmentId == departmentId)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }


        public static bool UpdateUserSiteKeyAndQA(string username, Dictionary<int,string> dictQandA, string strSSN, string strSiteKey,string siteKeyDesc)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }
                    User updatedUser = users.First();
                    List<SecurityQuestion> lstSecQA = new List<SecurityQuestion>();

                    foreach (var dictVar in dictQandA)
                    {
                        SecurityQuestion objSec = new SecurityQuestion();
                        objSec.userId = updatedUser.id;
                        objSec.questionId = dictVar.Key;
                        objSec.answer = dictVar.Value;
                        lstSecQA.Add(objSec);
                    }

                    SecurityQuestion objSec1 = new SecurityQuestion();
                    SecurityQuestion objSec2 = new SecurityQuestion();
                    SecurityQuestion objSec3 = new SecurityQuestion();

                    objSec1 = lstSecQA.First();
                    objSec2 = lstSecQA.ElementAt(1);
                    objSec3 = lstSecQA.Last();

                    updatedUser.SecurityQuestions = lstSecQA;
                    updatedUser.siteKeyVal = Convert.ToInt16(strSiteKey);
                    updatedUser.siteKeyString = siteKeyDesc;
                    updatedUser.SetHashForPassword(strSSN);

                    db.Users.Attach(updatedUser);
                    //User Model
                    var vsiteKeyDesc = db.Entry(updatedUser);
                    vsiteKeyDesc.Property(e => e.siteKeyString).IsModified = true;
                    var vsiteKeyVal = db.Entry(updatedUser);
                    vsiteKeyVal.Property(e => e.siteKeyVal).IsModified = true;
                    var vSSN = db.Entry(updatedUser);
                    vSSN.Property(e=>e.socialSecurityNumber).IsModified = true;
                    db.SaveChanges();

                    Tlog.Debug("User: " + username + " successfully updated QandA and SiteKey");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool UpdateUser(string username, string email, string staddress, string city, string state, string zipCode, string phoneNo)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User updatedUser = users.First();
                    Address address = updatedUser.Address;
                    address.city = city;
                    address.state = state;
                    address.street1 = staddress;
                    address.zip = Convert.ToInt32(zipCode);
                    updatedUser.phone = phoneNo;
                    updatedUser.email = email;

                    db.Users.Attach(updatedUser);
                    db.Addresses.Attach(address);

                    //User Model
                    var vemail = db.Entry(updatedUser);
                    vemail.Property(e => e.email).IsModified = true;
                    var vphoneNo = db.Entry(updatedUser);
                    vphoneNo.Property(e => e.phone).IsModified = true;
                    //Address Models
                    var vaddr_zip = db.Entry(address);
                    vaddr_zip.Property(e => e.zip).IsModified = true;
                    var vaddr_street1 = db.Entry(address);
                    vaddr_street1.Property(e => e.street1).IsModified = true;
                    var vaddr_street2 = db.Entry(address);
                    vaddr_street2.Property(e => e.street2).IsModified = true;
                    var vaddr_city = db.Entry(address);
                    vaddr_city.Property(e => e.city).IsModified = true;
                    var vaddr_state = db.Entry(address);
                    vaddr_state.Property(e => e.state).IsModified = true;
                    db.SaveChanges();

                    Tlog.Debug("User: " + username + " successfully updated");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool UpdateUser(string strUserName, bool isLockNeeded)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", strUserName).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User updatedUser = users.First();
                    if (isLockNeeded)
                    {
                        updatedUser.lockoutTime = DateTime.Now.AddHours(1);
                    }
                    else
                    {
                        updatedUser.lockoutTime = null;
                    }
                    db.Users.Attach(updatedUser);
                    var locktime = db.Entry(updatedUser);
                    locktime.Property(e => e.lockoutTime).IsModified = true;
                    db.SaveChanges();

                    Tlog.Debug("User: " + strUserName + " lockout time successfully updated");

                    return true;
                }                
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool UpdateUserActiveStatus(string strUserName,bool active)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", strUserName).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User updatedUser = users.First();
                    updatedUser.isActive = active;
                    db.Users.Attach(updatedUser);
                    var isActiveVar = db.Entry(updatedUser);
                    isActiveVar.Property(e => e.isActive).IsModified = true;
                    db.SaveChanges();

                    Tlog.Debug("User: " + strUserName + " active status updated");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool UpdateUserSessionID(string strUserName, string sessionid)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", strUserName).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User updatedUser = users.First();
                    updatedUser.sessionId = sessionid;
                    db.Users.Attach(updatedUser);
                    var sessionIdVar = db.Entry(updatedUser);
                    sessionIdVar.Property(e => e.sessionId).IsModified = true;
                    db.SaveChanges();

                    Tlog.Debug("User: " + strUserName + " session id updated");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }



        // Needs to be removed. (no one should be able to do this without access)
        public static bool TransferToDept(string username, int ToDepartmentId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return false;
                    }

                    User user = users.First();
                    user.departmentId = ToDepartmentId;
                    db.Users.Attach(user);
                    var vdeptId = db.Entry(user);
                    vdeptId.Property(e => e.departmentId).IsModified = true;
                    
                    db.SaveChanges();

                    Tlog.Debug("User: " + username + " transfered departments successfully");

                    return true;
                   
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static List<int> GetUserCount()
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    IEnumerable<int> objCounts = db.Database.SqlQuery<int>("select sum(case when roleId = 4 and departmentId = 2 then 1 else 0 end) RegSales," +
                                                           "sum(case when roleId = 4 and departmentId = 3 then 1 else 0 end) RegIT," +
                                                            "sum(case when roleId = 4 and departmentId = 5 then 1 else 0 end) RegHR," +
                                                            "sum(case when roleId = 5 and departmentId = 2 then 1 else 0 end) MgrSales," +
                                                            "sum(case when roleId = 5 and departmentId = 3 then 1 else 0 end) MgrIT," +
                                                            "sum(case when roleId = 5 and departmentId = 5 then 1 else 0 end) DeptHR," +
                                                            "sum(case when roleId = 6 and departmentId = 2 then 1 else 0 end) HgrSales," +
                                                            "sum(case when roleId = 6 and departmentId = 3 then 1 else 0 end) HgrIT," +
                                                            "sum(case when roleId = 6 and departmentId = 5 then 1 else 0 end) HgrHR from dbo.Users;");

                    return objCounts.ToList();
                }
            }
            catch( Exception exp)
            {
                Elog.Error("Exception : " + exp.Message);
                return null;
            }
        }
    }
}