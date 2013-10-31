using log4net;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{

    public class LoginModel
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

        // Returns: True false if the user information exists
        public static bool UserExists(string username, int zip)
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
                    if (address == null)
                    {
                        return false;
                    }

                    if (address.zip != zip)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        // Returns:
        // -1 if login fails
        // the row id if login success (UserId)
        public static int LoginUser(string username, string password)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return -1;
                    }

                    User user = users.First();

                    if (!user.VerifyPassword(password))
                    {
                        return -1;
                    }
                    user.lockoutTime = null;
                    db.Users.Attach(user);
                    var locktime = db.Entry(user);
                    locktime.Property(e => e.lockoutTime).IsModified = true;
                    db.SaveChanges();
                    return user.id;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return -1;
            }
        }
    }
}