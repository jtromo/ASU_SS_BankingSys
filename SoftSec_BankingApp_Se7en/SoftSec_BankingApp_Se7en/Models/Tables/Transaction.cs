using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Transaction
    {
        public int id { get; set; }
        public int accountNumber { get; set; }
        public string description { get; set; }
        public int type { get; set; }
        public int status { get; set; }
        public double amount { get; set; }
        public System.DateTimeOffset processedTime { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
        public System.DateTimeOffset modificationTime { get; set; }
        public System.DateTimeOffset deletionTime { get; set; }

        public virtual Account Account { get; set; }
    }
}