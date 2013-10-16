namespace SoftSec_BankingApp_Se7en.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accountNumber = c.Int(nullable: false),
                        routingNumber = c.Int(nullable: false),
                        accountTypeId = c.Int(nullable: false),
                        primaryUserId = c.Int(nullable: false),
                        balance = c.Double(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        billingAddressId = c.Int(nullable: false),
                        creationTime = c.DateTimeOffset(nullable: false),
                        modificationTime = c.DateTimeOffset(nullable: false),
                        deletionTime = c.DateTimeOffset(nullable: false),
                        Address_id = c.Int(),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AccountTypes", t => t.accountTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.Address_id)
                .ForeignKey("dbo.Users", t => t.User_id)
                .Index(t => t.accountTypeId)
                .Index(t => t.Address_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        street1 = c.String(),
                        street2 = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zip = c.String(maxLength: 5),
                        country = c.String(),
                        isActive = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        roleId = c.Int(nullable: false),
                        firstName = c.String(),
                        middleName = c.String(),
                        lastName = c.String(),
                        username = c.String(),
                        email = c.String(),
                        salt = c.String(),
                        hash = c.String(),
                        phone = c.String(),
                        organization = c.String(),
                        siteKeyVal = c.Int(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        creationTime = c.DateTimeOffset(nullable: false),
                        modificationTime = c.DateTimeOffset(nullable: false),
                        deletionTime = c.DateTimeOffset(nullable: false),
                        lockoutTime = c.DateTimeOffset(nullable: false),
                        UserDepartment_id = c.Int(),
                        Address_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Roles", t => t.roleId, cascadeDelete: true)
                .ForeignKey("dbo.UserDepartments", t => t.UserDepartment_id)
                .ForeignKey("dbo.Addresses", t => t.Address_id)
                .Index(t => t.roleId)
                .Index(t => t.UserDepartment_id)
                .Index(t => t.Address_id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SecurityQuestions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        questionId = c.Int(nullable: false),
                        answer = c.String(),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Questions", t => t.questionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.questionId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        question1 = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.UserDepartments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        departmentId = c.Int(nullable: false),
                        isActive = c.Int(nullable: false),
                        creationTime = c.DateTimeOffset(nullable: false),
                        modificationTime = c.DateTimeOffset(nullable: false),
                        deletionTime = c.DateTimeOffset(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.departmentId, cascadeDelete: true)
                .Index(t => t.departmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cardNumber = c.Int(nullable: false),
                        accountNumber = c.Int(nullable: false),
                        cvv = c.Int(nullable: false),
                        experationDate = c.Int(nullable: false),
                        firstName = c.String(),
                        middleInitial = c.String(),
                        lastName = c.String(),
                        isCredit = c.Boolean(nullable: false),
                        Account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Accounts", t => t.Account_id)
                .Index(t => t.Account_id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accountNumber = c.Int(nullable: false),
                        description = c.String(),
                        type = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        amount = c.Double(nullable: false),
                        processedTime = c.DateTimeOffset(nullable: false),
                        creationTime = c.DateTimeOffset(nullable: false),
                        modificationTime = c.DateTimeOffset(nullable: false),
                        deletionTime = c.DateTimeOffset(nullable: false),
                        Account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Accounts", t => t.Account_id)
                .Index(t => t.Account_id);
            
            CreateTable(
                "dbo.CheckingAccounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accountNumber = c.Int(nullable: false),
                        routingNumber = c.Int(nullable: false),
                        interestRate = c.Double(nullable: false),
                        Account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Accounts", t => t.Account_id)
                .Index(t => t.Account_id);
            
            CreateTable(
                "dbo.CreditAccounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accountNumber = c.Int(nullable: false),
                        creditLimit = c.Double(nullable: false),
                        paymentDueDay = c.Int(nullable: false),
                        interestRate = c.Double(nullable: false),
                        Account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Accounts", t => t.Account_id)
                .Index(t => t.Account_id);
            
            CreateTable(
                "dbo.SavingsAccounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accountNumber = c.Int(nullable: false),
                        routingNumber = c.Int(nullable: false),
                        minimumBalance = c.Double(nullable: false),
                        withdrawlNumLimit = c.Int(nullable: false),
                        interestRate = c.Double(nullable: false),
                        Account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Accounts", t => t.Account_id)
                .Index(t => t.Account_id);
            
            CreateTable(
                "dbo.Statements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accountNumber = c.Int(nullable: false),
                        statementStart = c.DateTimeOffset(nullable: false),
                        statementEnd = c.DateTimeOffset(nullable: false),
                        endingBalance = c.Double(nullable: false),
                        creationDate = c.DateTimeOffset(nullable: false),
                        Account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Accounts", t => t.Account_id)
                .Index(t => t.Account_id);
            
            CreateTable(
                "dbo.SystemLogs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        messageType = c.Int(nullable: false),
                        context = c.String(),
                        ip = c.String(),
                        component = c.String(),
                        process = c.String(),
                        message = c.String(),
                        time = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Statements", new[] { "Account_id" });
            DropIndex("dbo.SavingsAccounts", new[] { "Account_id" });
            DropIndex("dbo.CreditAccounts", new[] { "Account_id" });
            DropIndex("dbo.CheckingAccounts", new[] { "Account_id" });
            DropIndex("dbo.Transactions", new[] { "Account_id" });
            DropIndex("dbo.Cards", new[] { "Account_id" });
            DropIndex("dbo.UserDepartments", new[] { "departmentId" });
            DropIndex("dbo.SecurityQuestions", new[] { "userId" });
            DropIndex("dbo.SecurityQuestions", new[] { "questionId" });
            DropIndex("dbo.Users", new[] { "Address_id" });
            DropIndex("dbo.Users", new[] { "UserDepartment_id" });
            DropIndex("dbo.Users", new[] { "roleId" });
            DropIndex("dbo.Accounts", new[] { "User_id" });
            DropIndex("dbo.Accounts", new[] { "Address_id" });
            DropIndex("dbo.Accounts", new[] { "accountTypeId" });
            DropForeignKey("dbo.Statements", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.SavingsAccounts", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.CreditAccounts", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.CheckingAccounts", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.Cards", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.UserDepartments", "departmentId", "dbo.Departments");
            DropForeignKey("dbo.SecurityQuestions", "userId", "dbo.Users");
            DropForeignKey("dbo.SecurityQuestions", "questionId", "dbo.Questions");
            DropForeignKey("dbo.Users", "Address_id", "dbo.Addresses");
            DropForeignKey("dbo.Users", "UserDepartment_id", "dbo.UserDepartments");
            DropForeignKey("dbo.Users", "roleId", "dbo.Roles");
            DropForeignKey("dbo.Accounts", "User_id", "dbo.Users");
            DropForeignKey("dbo.Accounts", "Address_id", "dbo.Addresses");
            DropForeignKey("dbo.Accounts", "accountTypeId", "dbo.AccountTypes");
            DropTable("dbo.SystemLogs");
            DropTable("dbo.Statements");
            DropTable("dbo.SavingsAccounts");
            DropTable("dbo.CreditAccounts");
            DropTable("dbo.CheckingAccounts");
            DropTable("dbo.Transactions");
            DropTable("dbo.Cards");
            DropTable("dbo.Departments");
            DropTable("dbo.UserDepartments");
            DropTable("dbo.Questions");
            DropTable("dbo.SecurityQuestions");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Addresses");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.Accounts");
        }
    }
}