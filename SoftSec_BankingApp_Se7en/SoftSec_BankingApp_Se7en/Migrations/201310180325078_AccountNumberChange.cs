namespace SoftSec_BankingApp_Se7en.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNumberChange : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Transactions DROP CONSTRAINT DF__Transacti__fromA__5070F446");
            Sql("ALTER TABLE dbo.Transactions DROP CONSTRAINT DF__Transacti__toAcc__5165187F");
            AddColumn("dbo.Cards", "expirationDate", c => c.String());
            AddColumn("dbo.Transactions", "fromRoutingNumber", c => c.String());
            AddColumn("dbo.Transactions", "toRoutingNumber", c => c.String());
            AlterColumn("dbo.Accounts", "accountNumber", c => c.String());
            AlterColumn("dbo.Accounts", "routingNumber", c => c.String());
            AlterColumn("dbo.Accounts", "modificationTime", c => c.DateTimeOffset());
            AlterColumn("dbo.Accounts", "deletionTime", c => c.DateTimeOffset());
            AlterColumn("dbo.UserDepartments", "modificationTime", c => c.DateTimeOffset());
            AlterColumn("dbo.UserDepartments", "deletionTime", c => c.DateTimeOffset());
            AlterColumn("dbo.Cards", "accountNumber", c => c.String());
            AlterColumn("dbo.CheckingAccounts", "accountNumber", c => c.String());
            AlterColumn("dbo.CheckingAccounts", "routingNumber", c => c.String());
            AlterColumn("dbo.CreditAccounts", "accountNumber", c => c.String());
            AlterColumn("dbo.SavingsAccounts", "accountNumber", c => c.String());
            AlterColumn("dbo.SavingsAccounts", "routingNumber", c => c.String());
            AlterColumn("dbo.Statements", "accountNumber", c => c.String());
            AlterColumn("dbo.Transactions", "fromAccountNumber", c => c.String());
            AlterColumn("dbo.Transactions", "toAccountNumber", c => c.String());
            DropColumn("dbo.Cards", "experationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cards", "experationDate", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "toAccountNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "fromAccountNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Statements", "accountNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.SavingsAccounts", "routingNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.SavingsAccounts", "accountNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.CreditAccounts", "accountNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.CheckingAccounts", "routingNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.CheckingAccounts", "accountNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Cards", "accountNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDepartments", "deletionTime", c => c.DateTimeOffset(nullable: false));
            AlterColumn("dbo.UserDepartments", "modificationTime", c => c.DateTimeOffset(nullable: false));
            AlterColumn("dbo.Accounts", "deletionTime", c => c.DateTimeOffset(nullable: false));
            AlterColumn("dbo.Accounts", "modificationTime", c => c.DateTimeOffset(nullable: false));
            AlterColumn("dbo.Accounts", "routingNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Accounts", "accountNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "toRoutingNumber");
            DropColumn("dbo.Transactions", "fromRoutingNumber");
            DropColumn("dbo.Cards", "expirationDate");
        }
    }
}
