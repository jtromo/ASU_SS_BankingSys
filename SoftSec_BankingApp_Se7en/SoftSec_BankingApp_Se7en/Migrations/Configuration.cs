namespace SoftSec_BankingApp_Se7en.Migrations
{
    using SoftSec_BankingApp_Se7en.Models.Tables;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoftSec_BankingApp_Se7en.Models.SSBankDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SoftSec_BankingApp_Se7en.Models.SSBankDBContext context)
        {
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Roles ON");
             context.Roles.AddOrUpdate(
                     new Role { id = 1, title = "No Access" },
                     new Role { id = 2, title = "External User" },
                     new Role { id = 3, title = "Internal User" },
                     new Role { id = 4, title = "Super User" }
                 );
             context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Roles OFF");
        }
    }
}
