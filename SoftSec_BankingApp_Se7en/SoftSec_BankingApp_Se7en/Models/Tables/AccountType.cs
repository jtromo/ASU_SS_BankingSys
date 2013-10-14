using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class AccountType
    {
        public AccountType()
        {
            this.Accounts = new HashSet<Account>();
        }

        public int id { get; set; }
        public string title { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}