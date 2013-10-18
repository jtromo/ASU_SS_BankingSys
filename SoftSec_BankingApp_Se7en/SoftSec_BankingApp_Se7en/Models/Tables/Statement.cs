using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Statement
    {
        public int id { get; set; }
        public string accountNumber { get; set; }
        public System.DateTimeOffset statementStart { get; set; }
        public System.DateTimeOffset statementEnd { get; set; }
        public double endingBalance { get; set; }
        public System.DateTimeOffset creationDate { get; set; }

        public virtual Account Account { get; set; }
    }
}