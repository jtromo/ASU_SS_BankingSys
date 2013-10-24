using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Transaction
    {
        public int id { get; set; }
        public string fromAccountNumber { get; set; }
        public string fromRoutingNumber { get; set; }
        public string toAccountNumber { get; set; }
        public string toRoutingNumber { get; set; }
        public string description { get; set; }
        public int type { get; set; }
        public int status { get; set; }
        public double amount { get; set; }
        public string mustBeAuthorizedByUserName { get; set; }
        public int? authorizedUserRole { get; set; } 
        public System.DateTimeOffset? processedTime { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
    }
}