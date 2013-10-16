using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class AccountModel
    {
        public ICollection<Tables.Account> GetAccountsForUser(string username)
        {
            using (var db = new SSBankDBContext())
            {
                List<User> users = db.Users.SqlQuery("SELECT * FROM dbo.Users WHERE username = @p0", username).ToList();

                if (users.Count() < 1)
                {
                    return null;
                }

                User user = users.First();
                ICollection<Tables.Account> accounts = user.Accounts;

                if (accounts == null)
                {
                    return null;
                }

                return accounts;
            }
        }

        public ICollection<Transaction> GetTransactionsForAccount(int accountNumber)
        {
            using (var db = new SSBankDBContext())
            {
                List<Tables.Account> accounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", accountNumber).ToList();

                if (accounts.Count() < 1)
                {
                    return null;
                }

                Tables.Account account = accounts.First();
                ICollection<Transaction> transactions = account.Transactions;

                if (transactions == null)
                {
                    return null;
                }

                return transactions;
            }
        }
    }
}