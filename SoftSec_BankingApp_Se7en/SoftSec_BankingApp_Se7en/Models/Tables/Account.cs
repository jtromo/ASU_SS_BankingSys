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
            this.Cards = new HashSet<Card>();
            this.Transactions = new HashSet<Transaction>();
        }

        public int id { get; set; }
        [MinLength(12)]
        [MaxLength(12)]
        public int accountNumber { get; set; }
        [MinLength(10)]
        [MaxLength(10)]
        public int routingNumber { get; set; }
        public int accountTypeId { get; set; }
        public int primaryUserId { get; set; }
        public double balance { get; set; }
        public bool isActive { get; set; }
        public int billingAddressId { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
        public System.DateTimeOffset modificationTime { get; set; }
        public System.DateTimeOffset deletionTime { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        //public virtual CheckingAccount CheckingAccount { get; set; }
        //public virtual CreditAccount CreditAccount { get; set; }
        //public virtual SavingsAccount SavingsAccount { get; set; }
        //public virtual Statement Statement { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}