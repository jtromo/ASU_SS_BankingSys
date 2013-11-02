using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class PkiCertificate
    {
        public int id { get; set; }
        public string username { get; set; }
        public string certificateName { get; set; }
    }
}