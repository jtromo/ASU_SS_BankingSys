using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSBank.Modules
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