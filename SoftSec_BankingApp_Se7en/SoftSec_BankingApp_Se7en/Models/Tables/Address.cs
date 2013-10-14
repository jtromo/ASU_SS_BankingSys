﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Address
    {
        public Address()
        {
            this.Accounts = new HashSet<Account>();
        }

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string isActive { get; set; }
        public System.DateTimeOffset creationDate { get; set; }
        public System.DateTimeOffset modificationDate { get; set; }
        public System.DateTimeOffset deletionDate { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}