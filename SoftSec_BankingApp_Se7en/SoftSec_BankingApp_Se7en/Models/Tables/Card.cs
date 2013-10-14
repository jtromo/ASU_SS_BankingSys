using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Card
    {
        public int id { get; set; }
        [MinLength(16)]
        [MaxLength(16)]
        public int cardNumber { get; set; }
        [MinLength(12)]
        [MaxLength(12)]
        public int accountNumber { get; set; }
        [MinLength(3)]
        [MaxLength(3)]
        public int cvv { get; set; }
        public int experationDate { get; set; }
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }
        public bool isCredit { get; set; }

        public virtual Account Account { get; set; }
    }
}