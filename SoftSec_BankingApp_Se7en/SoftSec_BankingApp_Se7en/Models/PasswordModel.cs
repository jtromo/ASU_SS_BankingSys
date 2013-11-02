using log4net;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class PasswordModel
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

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
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        private static string GenerateRandomPassword()
        {
            try
            {
                string password = "";
                int passwordLength = 14,r,k;
                char[] upperCase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                char[] lowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                char[] specialChar = { '!', '@', '#', '$', '%', '^', '&', '*' };
                Random rRandom = new Random();

                for (int i = 0; i < passwordLength; i++)
                {
                    r = rRandom.Next(4);

                    if (r == 0)
                    {
                        k = rRandom.Next(0, 25);
                        password += upperCase[k];
                    }

                    else if (r == 1)
                    {
                        k = rRandom.Next(0, 25);
                        password += lowerCase[k];
                    }

                    else if (r == 2)
                    {
                        k = rRandom.Next(0, 9);
                        password += numbers[k];
                    }
                    else if (r == 3)
                    {
                        k = rRandom.Next(0, 7);
                        password += specialChar[k];
                    }

                }
                return password;
            }
            catch (Exception exp)
            {
                Elog.Error("Exception : Password Failed - " + exp.Message);
                return string.Empty;
            }
        }

        public static string MailPwd(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                    if (users.Count() < 1)
                    {
                        return string.Empty;
                    }

                    User updatedUser = users.First();
                    string password = GenerateRandomPassword();
                    updatedUser.SetHashForPassword(password);
                    db.Users.Attach(updatedUser);
                    var entry = db.Entry(updatedUser);
                    entry.Property(e => e.hash).IsModified = true;
                    entry.Property(e => e.salt).IsModified = true;
                    db.SaveChanges();

                    Tlog.Debug("Password for user: " + username + " changed successfully");

                    return password;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return string.Empty;
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
                    updatedUser.SetHashForPassword(password);
                    db.Users.Attach(updatedUser);
                    var entry = db.Entry(updatedUser);
                    entry.Property(e => e.hash).IsModified = true;
                    entry.Property(e => e.salt).IsModified = true;
                    db.SaveChanges();

                    Tlog.Debug("Password for user: " + username + " changed successfully");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }
    }
}