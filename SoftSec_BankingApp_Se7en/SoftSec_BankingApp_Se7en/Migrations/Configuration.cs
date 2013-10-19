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
            // Adds initial roles
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Roles ON");
            context.Roles.AddOrUpdate(
                    new Role { id = 1, title = "No Access" },
                    new Role { id = 2, title = "External Individual" },
                    new Role { id = 3, title = "External Merchant" },
                    new Role { id = 4, title = "Internal Regular" },
                    new Role { id = 5, title = "Internal DeptMgr" },
                    new Role { id = 6, title = "Internal HigherMgr" },
                    new Role { id = 7, title = "Admin" },
                    new Role { id = 8, title = "SuperUser" }
                );
            context.SaveChanges();
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Roles OFF");

            // Adds initial questions
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Questions ON");
            context.Questions.AddOrUpdate(
                    new Question { id = 1, question1 = "What was the name of your first pet?" },
                    new Question { id = 2, question1 = "What was the name of your childhood best friend?" },
                    new Question { id = 3, question1 = "What was the name of your first school?" },
                    new Question { id = 4, question1 = "What is your mother's maiden name?" }
                );
            context.SaveChanges();
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Questions OFF");

            // Adds initial account types
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.AccountTypes ON");
            context.AccountTypes.AddOrUpdate(
                    new AccountType { id = 1, title = "Unknown" },
                    new AccountType { id = 2, title = "Checking" },
                    new AccountType { id = 3, title = "Savings" }
                );
            context.SaveChanges();
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.AccountTypes OFF");
        }
    }
}
