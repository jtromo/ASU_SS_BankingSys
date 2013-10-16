using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Transaction
    {
        public int id { get; set; }
        public int fromAccountNumber { get; set; }
        public int toAccountNumber { get; set; }
        public string description { get; set; }
        public int type { get; set; }
        public int status { get; set; }
        public double amount { get; set; }
        public System.DateTimeOffset processedTime { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
    }
}