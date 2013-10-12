using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSBank.Modules
{
    public class Account
    {
        public Account()
        {
            //this.Cards = new HashSet<Card>();
            //this.Transactions = new HashSet<Transaction>();
        }

        public int id { get; set; }
        public int accountNumber { get; set; }
        public int routingNumber { get; set; }
        public int accountTypeId { get; set; }
        public int primaryUserId { get; set; }
        public double balance { get; set; }
        public bool isActive { get; set; }
        public int billingAddressId { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
        public System.DateTimeOffset modificationTime { get; set; }
        //public System.DateTimeOffset deletionTime { get; set; }

       // public virtual AccountType AccountType { get; set; }
       // public virtual Address Address { get; set; }
        public virtual User User { get; set; }
       // public virtual ICollection<Card> Cards { get; set; }
       // public virtual CheckingAccount CheckingAccount { get; set; }
       // public virtual CreditAccount CreditAccount { get; set; }
       // public virtual SavingsAccount SavingsAccount { get; set; }
       // public virtual Statement Statement { get; set; }
        //public virtual ICollection<Transaction> Transactions { get; set; }
    }
}