using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class User
    {
        public User()
        {
            this.Accounts = new HashSet<Account>();
            this.SecurityQuestions = new HashSet<SecurityQuestion>();
            this.Address = new Address();
        }

        public int id { get; set; }
        public int roleId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string salt { get; set; }
        public string hash { get; set; }
        public string phone { get; set; }
        public string organization { get; set; }
        [MinLength(1)]
        [MaxLength(15)]
        public int siteKeyVal { get; set; }
        public bool isActive { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
        public System.DateTimeOffset modificationTime { get; set; }
        public System.DateTimeOffset deletionTime { get; set; }
        public System.DateTimeOffset lockoutTime { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<SecurityQuestion> SecurityQuestions { get; set; }
        public virtual UserDepartment UserDepartment { get; set; }
        public virtual Address Address { get; set; }
    }
}