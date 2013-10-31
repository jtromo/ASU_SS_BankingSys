using log4net;
using SoftSec_BankingApp_Se7en.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class AccountModel
    {
        private static readonly ILog Elog = LogManager.GetLogger("ExceptionFileAppender");
        private static readonly ILog Tlog = LogManager.GetLogger("TransactionsFileAppender");

        // Can get balance from here
        public static Tables.Account GetAccount(string accountNumber)
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
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static Card GetCardDetails(string cardNumber, string accNumber)
        {
            try
            {
                using (var db = new SSBankDBContext())
                {
                    List<Card> cards = db.Cards.SqlQuery("SELECT * FROM dbo.Cards WHERE cardNumber = @p0 AND accountNumber = @p1", cardNumber, accNumber).ToList();

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
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static Card GetCardDetails(string cardNumber)
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
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static ICollection<Tables.Account> GetAccountsForUser(string username)
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
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
            }
        }

        public static LastNameZipcode GetLastNameAndZipcode(string accountNumber)
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
                Elog.Error("Exception occurred: " + exp.Message);
                return null;
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