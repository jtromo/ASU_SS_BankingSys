﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Address
    {
        public Address()
        {
        }

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        [MinLength(5)]
        [MaxLength(5)]
        public string zip { get; set; }
        public string country { get; set; }
        public string isActive { get; set; }
    }
}