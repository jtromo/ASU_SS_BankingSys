using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Transactions;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class TransactionModel
    {
        public const int TRANSFER_TYPE_INTERNAL = 1;
        public const int TRANSFER_TYPE_EXTERNAL = 2;

        public static ICollection<Tables.Transaction> GetTransactionsForAccount(string accountNumber)
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

        public static bool MakeInternalTransfer(string fromAccountNumber, string toAccountNumber, double amount, string description)
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
        public static bool MakeExternalTransfer(string fromAccountNumber, string toAccountNumber, string toRoutingNumber, double amount, string description)
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
}