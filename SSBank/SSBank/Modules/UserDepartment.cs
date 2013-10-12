using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SSBank.Modules
{
    public class UserDepartment
    {
        public int id { get; set; }

        public int userId { get; set; }
        public int departmentId { get; set; }
        public int isActive { get; set; }
        public System.DateTimeOffset creationTime { get; set; }
        public System.DateTimeOffset modificationTime { get; set; }
        public System.DateTimeOffset deletionTime { get; set; }

        public virtual Department Department { get; set; }

        //public virtual User User { get; set; }
    }
}