using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class PasswordModel
    {
        public static List<SecurityQuestion> GetSecurityQandA(string username)
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
                    List<SecurityQuestion> securityQuestions = user.SecurityQuestions.ToList();

                    if (securityQuestions.Count() > 0)
                    {
                        return securityQuestions;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public static bool ChangePwd(string username, string password)
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
                    updatedUser.SetHashandSaltForPassword(password);
                    db.Users.Attach(updatedUser);
                    var entry = db.Entry(updatedUser);
                    entry.Property(e => e.hash).IsModified = true;
                    entry.Property(e => e.salt).IsModified = true;
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