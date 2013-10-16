using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class AccountModel
    {
        public ICollection<SoftSec_BankingApp_Se7en.Models.Tables.Account> GetAccountsForUser(string username)
        {
            using (var db = new SSBankDBContext())
            {
                List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                if (users.Count() < 1)
                {
                    return null;
                }

                User user = users.First();
                ICollection<SoftSec_BankingApp_Se7en.Models.Tables.Account> accounts = user.Accounts;

                if (accounts == null)
                {
                    return null;
                }


                return accounts;
            }
        }
    }
}