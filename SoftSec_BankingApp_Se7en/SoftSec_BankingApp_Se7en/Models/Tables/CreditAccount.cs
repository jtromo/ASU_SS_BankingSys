using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class CreditAccount
    {
        public int id { get; set; }
        public int accountNumber { get; set; }
        public double creditLimit { get; set; }
        public int paymentDueDay { get; set; }
        public double interestRate { get; set; }

        public virtual Account Account { get; set; }
    }
}