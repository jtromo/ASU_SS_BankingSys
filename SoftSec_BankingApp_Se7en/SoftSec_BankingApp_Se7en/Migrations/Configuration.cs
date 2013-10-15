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
                    new Role { id = 2, title = "External User" },
                    new Role { id = 3, title = "Internal User" },
                    new Role { id = 4, title = "Super User" }
                );
            context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Roles OFF");

            // Adds initial questions
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Questions ON");
            context.Questions.AddOrUpdate(
                    new Question { id = 1, question1 = "What was the name of your first pet?" },
                    new Question { id = 2, question1 = "What was the name of your childhood best friend?" },
                    new Question { id = 3, question1 = "What was the name of your first school?" },
                    new Question { id = 4, question1 = "What is your mother's maiden name?" }
                );
            context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Questions OFF");
        }
    }
}
