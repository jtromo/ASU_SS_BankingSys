using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class SavingsAccount
    {
        public int id { get; set; }
        public string accountNumber { get; set; }
        public string routingNumber { get; set; }
        public double minimumBalance { get; set; }
        public int withdrawlNumLimit { get; set; }
        public double interestRate { get; set; }

        public virtual Account Account { get; set; }
    }
}