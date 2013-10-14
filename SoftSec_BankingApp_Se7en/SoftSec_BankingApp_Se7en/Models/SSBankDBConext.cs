using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SoftSec_BankingApp_Se7en.Models.Tables;

namespace SoftSec_BankingApp_Se7en.Models
{
    public class SSBankDBContext : DbContext
    {
       //public DbSet<Account> Accounts { get; set; }
        /*public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CheckingAccount> CheckingAccounts { get; set; }
        public DbSet<CreditAccount> CreditAccounts { get; set; }*/
        public DbSet<Department> Departments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Role> Roles { get; set; }
       /* public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<Statement> Statements { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        public DbSet<Transaction> Transactions { get; set; }*/
        public DbSet<User> Users { get; set; }
        public DbSet<UserDepartment> UserDepartments { get; set; }
    }
}