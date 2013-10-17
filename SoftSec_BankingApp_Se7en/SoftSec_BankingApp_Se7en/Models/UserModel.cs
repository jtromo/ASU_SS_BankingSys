using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class UserModel
    {
        public bool creatUser(User newUser, Address address, SecurityQandA securityQandA)
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
                db.Users.Add(newUser);
                db.SaveChanges();

                /*List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                if (users.Count() < 1)
                {
                    return false;
                }

                User user = users.First();
                Address address = user.Address;
                ICollection<SecurityQuestion> securityQandA = user.SecurityQuestions;
                */
                return true;
            }
        }

        public User GetUser(string username)
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
    }
}