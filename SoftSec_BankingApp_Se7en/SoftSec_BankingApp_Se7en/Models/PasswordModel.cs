using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class PasswordModel
    {
        public ICollection<String> GetSecurityQandA(String username)
        {
            return null;
        }

        public bool ChangePwd(String username, String password)
        {
            using (var db = new SSBankDBContext())
            {
                List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                if (users.Count() < 1)
                {
                    return false;
                }

                User updatedUser = users.First();
                // JR: warning! need to change this to hash
                updatedUser.hash = password;

                db.Users.Attach(updatedUser);
                var entry = db.Entry(updatedUser);
                entry.Property(e => e.hash).IsModified = true;
                db.SaveChanges();

                return true;
            }
        }
    }
}