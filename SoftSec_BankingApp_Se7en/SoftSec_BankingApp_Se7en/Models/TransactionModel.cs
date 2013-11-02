using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Transactions;
using SoftSec_BankingApp_Se7en.Models.Tables;
using log4net;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class TransactionModel
    {
        public const int TRANSFER_TYPE_INTERNAL = 1;
        public const int TRANSFER_TYPE_EXTERNAL = 2;
        public const int TRANSFER_TYPE_WITHDRAW = 3;
        public const int TRANSFER_TYPE_DEPOSIT = 4;

        // Transfer limit before transfer requires approval
        public const int TRANSFER_LIMIT = 1000;

        // Transactions > than TRANSFER_LIMIT must be approved
        public const int TRANSFER_STATUS_PROCESSING = 1;
        public const int TRANSFER_STATUS_APPROVED = 2;
        public const int TRANSFER_STATUS_REJECTED = 3;

        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

        public static List<Tables.Transaction> GetTransactionsForAccount(string accountNumber)
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
                    List<Tables.Transaction> transactions = account.Transactions.ToList();

                    if (transactions == null)
                    {
                        return null;
                    }

                    return transactions;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static Tables.Transaction GetTransaction(string strTransID)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE id = @p0", strTransID).ToList();

                    if (transactions.Count() < 1)
                    {
                        return null;
                    }

                    return transactions.First();
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<Tables.Transaction> GetTransactionsForFromAccount(string accountNumber)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE fromAccountNumber = @p0", accountNumber).ToList();

                    if (transactions.Count() < 1)
                    {
                        return null;
                    }

                    return transactions;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<Tables.Transaction> GetTransactionsForFromToAccount(string accountNumber)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE fromAccountNumber = @p0 OR toAccountNumber =@p1", accountNumber, accountNumber).ToList();

                    if (transactions.Count() < 1)
                    {
                        return null;
                    }

                    return transactions;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<Tables.Transaction> GetTransactionsForUser(string username)
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
                    List<Tables.Account> accounts = user.Accounts.ToList();

                    if (accounts.Count() < 1)
                    {
                        return null;
                    }

                    List<Tables.Transaction> transactions = new List<Tables.Transaction>();
                    foreach (Tables.Account account in accounts)
                    {
                        List<Tables.Transaction> accountTransactions = account.Transactions.ToList();
                        if (accountTransactions.Count() > 0)
                            transactions.AddRange(accountTransactions);
                    }

                    return transactions;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static List<Tables.Transaction> GetAuthorizationRequestedTransactionsForUser(string username)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE mustBeAuthorizedByUserName = @p0 AND status =1", username).ToList();

                    if (transactions.Count() < 1)
                    {
                        return null;
                    }

                    return transactions;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static bool AssignAuthorizationRequestedTransactionToUser(int transactionId, string username, int roleId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE id = @p0", transactionId).ToList();

                    if (transactions.Count() < 1)
                    {
                        return false;
                    }

                    Tables.Transaction transaction = transactions.First();

                    transaction.mustBeAuthorizedByUserName = username;
                    transaction.authorizedUserRoleId = roleId;

                    db.Transactions.Attach(transaction);

                    var vmustBeAuthorizedByUserName = db.Entry(transaction);
                    vmustBeAuthorizedByUserName.Property(e => e.mustBeAuthorizedByUserName).IsModified = true;
                    var vauthorizedUserRole = db.Entry(transaction);
                    vauthorizedUserRole.Property(e => e.authorizedUserRoleId).IsModified = true;

                    db.SaveChanges();

                    Tlog.Debug("Authorization request for user: " + username + " added successfully");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool ApproveTransaction(int transactionId)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (var db = new SSBankDBContext())
                    {
                        List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE id = @p0", transactionId).ToList();

                        if (transactions.Count() < 1)
                        {
                            return false;
                        }
                        // Process Transaction
                        Tables.Transaction transaction = transactions.First();

                        

                        // Perform Action
                        switch (transaction.status)
                        {
                            case TRANSFER_TYPE_INTERNAL:
                                {
                                    // Internal Transfer Actions
                                    List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", transaction.fromAccountNumber).ToList();
                                    if (fromAccounts.Count() < 1)
                                    {
                                        return false;
                                    }
                                    Tables.Account fromAccount = fromAccounts.First();

                                    List<Tables.Account> toAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", transaction.toAccountNumber).ToList();
                                    if (toAccounts.Count() < 1)
                                    {
                                        return false;
                                    }
                                    Tables.Account toAccount = toAccounts.First();

                                    if ((fromAccount.balance - transaction.amount) < 0)
                                    {
                                        return false;
                                    }

                                    fromAccount.balance = fromAccount.balance - transaction.amount;
                                    toAccount.balance = toAccount.balance + transaction.amount;
                                }
                                break;
                            case TRANSFER_TYPE_EXTERNAL:
                                {
                                    // External Transfer Actions
                                    List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", transaction.fromAccountNumber).ToList();
                                    if (fromAccounts.Count() < 1)
                                    {
                                        return false;
                                    }
                                    Tables.Account fromAccount = fromAccounts.First();

                                    if ((fromAccount.balance - transaction.amount) < 0)
                                    {
                                        return false;
                                    }

                                    fromAccount.balance = fromAccount.balance - transaction.amount;
                                }
                                break;
                            case TRANSFER_TYPE_WITHDRAW:
                                {
                                    // Withdraw Actions
                                    List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", transaction.fromAccountNumber).ToList();
                                    if (fromAccounts.Count() < 1)
                                    {
                                        return false;
                                    }
                                    Tables.Account account = fromAccounts.First();

                                    if ((account.balance - transaction.amount) < 0)
                                    {
                                        // OVERDRAFT!
                                        Tlog.Error("Overdraft occured on account: " + account.accountNumber);
                                        return false;
                                    }

                                    account.balance = account.balance - transaction.amount;
                                }
                                break;
                            case TRANSFER_TYPE_DEPOSIT:
                                {
                                    // Deposits do not need authorization
                                    return false;
                                }
                            default:
                                {
                                    // Error
                                    return false;
                                }
                        }

                        DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                        transaction.status = TRANSFER_STATUS_APPROVED;
                        transaction.processedTime = timestamp;

                        db.Transactions.Attach(transaction);
                        var vstatus = db.Entry(transaction);
                        vstatus.Property(e => e.status).IsModified = true;
                        var vprocessedTime = db.Entry(transaction);
                        vprocessedTime.Property(e => e.processedTime).IsModified = true;

                        db.SaveChanges();
                        scope.Complete();

                        Tlog.Debug("Transaction: " + transactionId + " approved successfully");

                        return true;
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool escalateTransaction(int transactionId,string newDescription,string toUSerName)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (var db = new SSBankDBContext())
                    {
                        List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE id = @p0", transactionId).ToList();

                        if (transactions.Count() < 1)
                        {
                            return false;
                        }

                        // Process Transaction
                        Tables.Transaction transaction = transactions.First();

                        DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                        transaction.status = TRANSFER_STATUS_PROCESSING;
                        transaction.description = newDescription;
                        transaction.mustBeAuthorizedByUserName = toUSerName;
                        transaction.processedTime = timestamp;
                        db.Transactions.Attach(transaction);
                        var vstatus = db.Entry(transaction);
                        vstatus.Property(e => e.status).IsModified = true;
                        var vprocessedTime = db.Entry(transaction);
                        vprocessedTime.Property(e => e.processedTime).IsModified = true;
                        var vdescription = db.Entry(transaction);
                        vdescription.Property(e => e.description).IsModified = true;
                        var vmustBeAuthorizedByUserName = db.Entry(transaction);
                        vmustBeAuthorizedByUserName.Property(e => e.mustBeAuthorizedByUserName).IsModified = true;
                        db.SaveChanges();
                        scope.Complete();

                        Tlog.Debug("Transaction: " + transactionId + " escalated successfully");

                        return true;
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static bool RejectTransaction(int transactionId)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Tables.Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE id = @p0", transactionId).ToList();

                    if (transactions.Count() < 1)
                    {
                        return false;
                    }

                    Tables.Transaction transaction = transactions.First();

                    transaction.status = TRANSFER_STATUS_REJECTED;

                    db.Transactions.Attach(transaction);

                    var vstatus = db.Entry(transaction);
                    vstatus.Property(e => e.status).IsModified = true;

                    db.SaveChanges();

                    Tlog.Debug("Transaction: " + transactionId + " rejected successfully");

                    return true;
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return false;
            }
        }

        public static int MakeInternalTransfer(string fromAccountNumber, string toAccountNumber, double amount, string description)
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
                            return -1;
                        }
                        Tables.Account fromAccount = fromAccounts.First();

                        List<Tables.Account> toAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", toAccountNumber).ToList();
                        if (toAccounts.Count() < 1)
                        {
                            return -1;
                        }
                        Tables.Account toAccount = toAccounts.First();

                        if ((fromAccount.balance - amount) < 0)
                        {
                            return -1;
                        }

                        Tables.Transaction transaction = new Tables.Transaction();
                        transaction.toAccountNumber = toAccountNumber;
                        transaction.fromAccountNumber = fromAccountNumber;
                        transaction.description = description;
                        transaction.amount = amount;
                        transaction.type = TRANSFER_TYPE_INTERNAL;
                        DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                        transaction.creationTime = timestamp;

                        // Transfer is less within limit range. The transaction goes through
                        if (amount <= TRANSFER_LIMIT)
                        {
                            fromAccount.balance = fromAccount.balance - amount;
                            toAccount.balance = toAccount.balance + amount;

                            transaction.status = TRANSFER_STATUS_APPROVED;
                            transaction.processedTime = timestamp;
                        }
                        // Transfer exceeds the limit. Must be authorized for it to go through
                        else
                        {
                            transaction.status = TRANSFER_STATUS_PROCESSING;
                        }

                        db.Transactions.Add(transaction);

                        db.SaveChanges();
                        scope.Complete();

                        Tlog.Debug("Internal transfer from account: " + fromAccountNumber + " made successfully");

                        return transaction.id;
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return -1;
            }
        }

        //Since its an outside bank account ! We need not worry about the balance of that account. We will not have the details of that account.
        public static int MakeExternalTransfer(string fromAccountNumber, string fromRoutingNumber, string toAccountNumber, string toRoutingNumber, double amount, string description)
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
                            return -1;
                        }
                        Tables.Account fromAccount = fromAccounts.First();

                        if ((fromAccount.balance - amount) < 0)
                        {
                            return -1;
                        }

                        Tables.Transaction transaction = new Tables.Transaction();
                        transaction.toAccountNumber = toAccountNumber;
                        transaction.toRoutingNumber = toRoutingNumber;
                        transaction.fromAccountNumber = fromAccountNumber;
                        transaction.fromRoutingNumber = fromRoutingNumber;
                        transaction.description = description;
                        transaction.amount = amount;
                        transaction.type = TRANSFER_TYPE_EXTERNAL;
                        DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                        transaction.creationTime = timestamp;

                        // Transfer is less within limit range. The transaction goes through
                        if (amount <= TRANSFER_LIMIT)
                        {
                            fromAccount.balance = fromAccount.balance - amount;

                            transaction.status = TRANSFER_STATUS_APPROVED;
                            transaction.processedTime = timestamp;
                        }
                        // Transfer exceeds the limit. Must be authorized for it to go through
                        else
                        {
                            transaction.status = TRANSFER_STATUS_PROCESSING;
                        }

                        db.Transactions.Add(transaction);

                        db.SaveChanges();
                        scope.Complete();

                        Tlog.Debug("External transfer from account: " + fromAccountNumber + " made successfully");

                        return transaction.id;
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return -1;
            }
        }

        public static int WithdrawFundsFromAccoount(string accountNumber, double amount)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (var db = new SSBankDBContext())
                    {
                        List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", accountNumber).ToList();
                        if (fromAccounts.Count() < 1)
                        {
                            return -1;
                        }
                        Tables.Account account = fromAccounts.First();

                        if ((account.balance - amount) < 0)
                        {
                            // OVERDRAFT!
                            Tlog.Error("Overdraft occured on account: " + account.accountNumber);
                            return -1;
                        }

                        Tables.Transaction transaction = new Tables.Transaction();
                        transaction.toAccountNumber = null;
                        transaction.toRoutingNumber = null;
                        transaction.fromAccountNumber = accountNumber;
                        transaction.fromRoutingNumber = null;
                        string description = "Withdraw: " + amount + " from account: " + accountNumber;
                        transaction.description = description;
                        transaction.amount = amount;
                        transaction.type = TRANSFER_TYPE_WITHDRAW;
                        DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                        transaction.creationTime = timestamp;

                        // Transfer is less within limit range. The transaction goes through
                        if (amount <= TRANSFER_LIMIT)
                        {
                            account.balance = account.balance - amount;

                            transaction.status = TRANSFER_STATUS_APPROVED;
                            transaction.processedTime = timestamp;
                        }
                        // Transfer exceeds the limit. Must be authorized for it to go through
                        else
                        {
                            transaction.status = TRANSFER_STATUS_PROCESSING;
                        }

                        db.Transactions.Add(transaction);

                        db.SaveChanges();
                        scope.Complete();

                        Tlog.Debug("Withdraw from account: " + accountNumber + " made successfully");

                        return transaction.id;
                    }
                }
            }
            catch (Exception exp)
            {
                Elog.Error("Exception occurred: " + exp.Message);
                return -1;
            }
        }

        public static int DepositFundsToAccoount(string accountNumber, double amount)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (var db = new SSBankDBContext())
                    {
                        List<Tables.Account> fromAccounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", accountNumber).ToList();
                        if (fromAccounts.Count() < 1)
                        {
                            return -1;
                        }
                        Tables.Account account = fromAccounts.First();

                        account.balance = account.balance + amount;

                        Tables.Transaction transaction = new Tables.Transaction();
                        transaction.toAccountNumber = accountNumber;
                        transaction.toRoutingNumber = null;
                        transaction.fromAccountNumber = null;
                        transaction.fromRoutingNumber = null;
                        string description = "Deposit: " + amount + " to account: " + accountNumber;
                        transaction.description = description;
                        transaction.amount = amount;
                        transaction.type = TRANSFER_TYPE_DEPOSIT;
                        transaction.status = TRANSFER_STATUS_APPROVED;
                        DateTimeOffset timestamp = new DateTimeOffset(DateTime.Now);
                        transaction.processedTime = timestamp;
                        transaction.creationTime = timestamp;
                        db.Transactions.Add(transaction);

                        db.SaveChanges();
                        scope.Complete();

                        Tlog.Debug("Deposit to account: " + accountNumber + " made successfully");

                        return transaction.id;
                    }
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