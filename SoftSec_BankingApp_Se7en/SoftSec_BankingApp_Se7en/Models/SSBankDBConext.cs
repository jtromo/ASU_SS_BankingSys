using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SSBank.Modules
{
    public class SSBankDBContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
    }
}