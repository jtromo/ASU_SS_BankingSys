using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class SystemLog
    {
        public int id { get; set; }
        public int messageType { get; set; }
        public string context { get; set; }
        public string ip { get; set; }
        public string component { get; set; }
        public string process { get; set; }
        public string message { get; set; }
        public string time { get; set; }
    }
}