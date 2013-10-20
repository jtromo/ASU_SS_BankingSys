using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Account
    {
        public Account()
        {
            this.Transactions = new HashSet<Transaction>();
        }
        [Key]
        public int id { get; set; }
        public string accountNumber { get; set; }
        public string routingNumber { get; set; }
        public int accountTypeId { get; set; }
        public double balance { get; set; }
        public bool isActive { get; set; }
        [Required]
        public System.DateTimeOffset creationTime { get; set; }
        public System.DateTimeOffset? modificationTime { get; set; }
        public System.DateTimeOffset? deletionTime { get; set; }
        public int userId { get; set; }
        public virtual User User { get; set; }
        public int? cardId { get; set; }
        public virtual Card Card { get; set; }
        private ICollection<Transaction> _transactions;
        [NotMapped]
        public virtual ICollection<Transaction> Transactions
        {
            get
            {
                using (var db = new SSBankDBContext())
                {
                    ICollection<Transaction> transactions = db.Transactions.SqlQuery("SELECT * FROM dbo.Transactions WHERE fromAccountNumber = @p0 OR toAccountNumber = @p0", accountNumber).ToList();
                    return transactions;
                }
            }
            set
            {
                _transactions = value;
            }
        }
    }
}