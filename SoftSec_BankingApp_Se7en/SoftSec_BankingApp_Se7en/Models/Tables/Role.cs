using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSBank.Modules
{
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }

        public int id { get; set; }
        public string title { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}