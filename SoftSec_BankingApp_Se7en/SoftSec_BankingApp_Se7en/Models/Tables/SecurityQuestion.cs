using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class SecurityQuestion
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int questionId { get; set; }
        public string answer { get; set; }
        public bool isActive { get; set; }

        public virtual Question Question { get; set; }
        public virtual User User { get; set; }
    }
}