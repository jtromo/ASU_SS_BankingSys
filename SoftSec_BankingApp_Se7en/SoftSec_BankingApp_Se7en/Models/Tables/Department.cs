using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftSec_BankingApp_Se7en.Models.Tables
{
    public class Department
    {
        public Department()
        {
            this.UserDepartments = new HashSet<UserDepartment>();
        }

        public int id { get; set; }
        public string title { get; set; }
        public bool isActive { get; set; }

        public virtual ICollection<UserDepartment> UserDepartments { get; set; }
    }
}