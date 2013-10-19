using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Card
    {
        public int id { get; set; }
        public string cardNumber { get; set; }
        public string accountNumber { get; set; }
        public int cvv { get; set; }
        public string expirationDate { get; set; }
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }

        private Account _account;
        [NotMapped]
        public virtual Account Account
        {
            get
            {
                using (var db = new SSBankDBContext())
                {
                    ICollection<Account> accounts = db.Accounts.SqlQuery("SELECT * FROM dbo.Accounts WHERE accountNumber = @p0", accountNumber).ToList();
                    if (accounts.Count() < 1)
                        return null;
                    Account account = accounts.First();
                    User user = account.User;
                    return account;
                }
            }
            set
            {
                _account = value;
            }
        }
    }
}