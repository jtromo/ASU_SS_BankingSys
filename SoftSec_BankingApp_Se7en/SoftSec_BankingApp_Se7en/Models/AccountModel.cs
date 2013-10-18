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
        public const int TRANSFER_TYPE_INTERNAL = 1;
        public const int TRANSFER_TYPE_EXTERNAL = 2;

        // Can get balance from here
        public Tables.Account GetAccount(string accountNumber)
        {
            try
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
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public Card GetCardDetails(string cardNumber)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Card> cards = db.Cards.SqlQuery("SELECT * FROM dbo.Cards WHERE cardNumber = @p0", cardNumber).ToList();

                    if (cards.Count() < 1)
                    {
                        return null;
                    }

                    Card card = cards.First();

                    return card;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public ICollection<Tables.Account> GetAccountsForUser(string username)
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
                    ICollection<Tables.Account> accounts = user.Accounts;

                    if (accounts == null)
                    {
                        return null;
                    }

                    return accounts;
                }
            }
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public ICollection<Tables.Transaction> GetTransactionsForAccount(string accountNumber)
        {
            try
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
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public LastNameZipcode GetLastNameAndZipcode(string accountNumber)
        {
            try
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
            catch (Exception exp)
            {
                //Log exception here
                return null;
            }
        }

        public bool MakeInternalTransfer(string fromAccountNumber, string toAccountNumber, double amount, string description)
        {
            try
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
                            toAccount.balance = toAccount.balance + amount;
                        }

                        Tables.Transaction transaction = new Tables.Transaction();
                        transaction.toAccountNumber = toAccountNumber;
                        transaction.fromAccountNumber = fromAccountNumber;
                        transaction.description = description;
                        transaction.amount = amount;
                        transaction.type = TRANSFER_TYPE_INTERNAL;
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
            catch (Exception exp)
            {
                //Log exception here
                return false;
            }
        }

        //Since its an outside bank account ! We need not worry about the balance of that account. We will not have the details of that account.
        public bool MakeExternalTransfer(string fromAccountNumber, string toAccountNumber, string toRoutingNumber, double amount, string description)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (var db = new SSBankDBContext())
                    {
                        string fromRoutingNumber = "why do we need this?";

                        //List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0 AND routingNumber = @p1", fromAccountNumber, fromRoutingNumber).ToList();
                        List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", fromAccountNumber).ToList();
                        if (fromAccounts.Count() < 1)
                        {
                            return false;
                        }
                        Tables.Account fromAccount = fromAccounts.First();

                        if ((fromAccount.balance - amount) >= 0)
                        {
                            fromAccount.balance = fromAccount.balance - amount;
                        }

                        Tables.Transaction transaction = new Tables.Transaction();
                        transaction.toAccountNumber = toAccountNumber;
                        transaction.fromAccountNumber = fromAccountNumber;
                        transaction.description = description;
                        transaction.amount = amount;
                        transaction.type = TRANSFER_TYPE_EXTERNAL;
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
            catch (Exception exp)
            {
                //Log exception here
                return false;
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