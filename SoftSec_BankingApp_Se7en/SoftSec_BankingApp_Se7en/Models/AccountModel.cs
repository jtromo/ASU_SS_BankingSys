using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Transactions;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class AccountModel
    {
        // Can get balance from here
        public Tables.Account GetAccount(int accountNumber)
        {
            using (var db = new SSBankDBContext())
            {
                List<Tables.Account> accounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", accountNumber).ToList();

                if (accounts.Count() < 1)
                {
                    return null;
                }

                Tables.Account account = accounts.First();

                return account;
            }
        }

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

        public ICollection<Tables.Transaction> GetTransactionsForAccount(int accountNumber)
        {
            using (var db = new SSBankDBContext())
            {
                List<Tables.Account> accounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", accountNumber).ToList();

                if (accounts.Count() < 1)
                {
                    return null;
                }

                Tables.Account account = accounts.First();
                ICollection<Tables.Transaction> transactions = account.Transactions;

                if (transactions == null)
                {
                    return null;
                }

                return transactions;
            }
        }

        public LastNameZipcode GetLastNameAndZipcode(int accountNumber)
        {
            using (var db = new SSBankDBContext())
            {
                List<Tables.Account> accounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", accountNumber).ToList();

                if (accounts.Count() < 1)
                {
                    return null;
                }

                Tables.Account account = accounts.First();

                User user = account.User;
                Address address = user.Address;

                LastNameZipcode lastnamezip = new LastNameZipcode(user.lastName, address.zip);

                if (lastnamezip == null)
                {
                    return null;
                }

                return lastnamezip;
            }
        }

        public bool MakeInternalTransfer(int fromAccountNumber, int toAccountNumber, double amount, string description)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", fromAccountNumber).ToList();
                    if (fromAccounts.Count() < 1)
                    {
                        return false;
                    }
                    Tables.Account fromAccount = fromAccounts.First();

                    List<Tables.Account> toAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", toAccountNumber).ToList();
                    if (toAccounts.Count() < 1)
                    {
                        return false;
                    }
                    Tables.Account toAccount = toAccounts.First();

                    if ((fromAccount.balance - amount) >= 0)
                    {
                        fromAccount.balance = fromAccount.balance - amount;
                        toAccount.balance = toAccount.balance - amount;
                    }

                    Tables.Transaction transaction = new Tables.Transaction();
                    transaction.toAccountNumber = toAccountNumber;
                    transaction.fromAccountNumber = fromAccountNumber;
                    transaction.description = description;
                    transaction.amount = amount;
                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    transaction.processedTime = timestamp;
                    transaction.creationTime = timestamp;
                    db.Transactions.Add(transaction);

                    db.SaveChanges();
                    scope.Complete();

                    return true;
                }
            }
        }

        public bool MakeExternalTransfer(int fromAccountNumber, int toAccountNumber, int toRoutingNumber, double amount, string description)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", fromAccountNumber).ToList();
                    if (fromAccounts.Count() < 1)
                    {
                        return false;
                    }
                    Tables.Account fromAccount = fromAccounts.First();

                    List<Tables.Account> toAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0 AND routingNumber = @p1", toAccountNumber, toRoutingNumber).ToList();
                    if (toAccounts.Count() < 1)
                    {
                        return false;
                    }
                    Tables.Account toAccount = toAccounts.First();

                    if ((fromAccount.balance - amount) >= 0)
                    {
                        fromAccount.balance = fromAccount.balance - amount;
                        toAccount.balance = toAccount.balance - amount;
                    }

                    Tables.Transaction transaction = new Tables.Transaction();
                    transaction.toAccountNumber = toAccountNumber;
                    transaction.fromAccountNumber = fromAccountNumber;
                    transaction.description = description;
                    transaction.amount = amount;
                    DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                    transaction.processedTime = timestamp;
                    transaction.creationTime = timestamp;
                    db.Transactions.Add(transaction);

                    db.SaveChanges();
                    scope.Complete();

                    return true;
                }
            }
        }
    }
    public class LastNameZipcode
    {
        public LastNameZipcode(string lastName, int zipcode)
        {
            this.lastName = lastName;
            this.zipcode = zipcode;
        }
        public string lastName;
        public int zipcode;
    }
}