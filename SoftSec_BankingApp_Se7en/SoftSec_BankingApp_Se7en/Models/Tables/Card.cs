﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Card
    {
        public int id { get; set; }
        public string cardNumber { get; set; }
        public string accountNumber { get; set; }
        public int cvv { get; set; }
        public string expirationDate { get; set; }
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }

        public virtual Account Account { get; set; }
    }
}