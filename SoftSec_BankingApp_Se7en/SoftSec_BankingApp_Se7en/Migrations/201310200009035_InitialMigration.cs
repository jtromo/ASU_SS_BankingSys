namespace SoftSec_BankingApp_Se7en.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accountNumber = c.String(),
                        routingNumber = c.String(),
                        accountTypeId = c.Int(nullable: false),
                        balance = c.Double(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        creationTime = c.DateTimeOffset(nullable: false),
                        modificationTime = c.DateTimeOffset(),
                        deletionTime = c.DateTimeOffset(),
                        userId = c.Int(nullable: false),
                        cardId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .ForeignKey("dbo.Cards", t => t.cardId)
                .Index(t => t.userId)
                .Index(t => t.cardId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        roleId = c.Int(),
                        addressId = c.Int(nullable: false),
                        departmentId = c.Int(),
                        firstName = c.String(),
                        middleName = c.String(),
                        lastName = c.String(),
                        username = c.String(),
                        email = c.String(),
                        salt = c.String(),
                        hash = c.String(),
                        phone = c.String(),
                        organization = c.String(),
                        socialSecurityNumber = c.String(),
                        dateOfBirth = c.String(),
                        siteKeyVal = c.Int(nullable: false),
                        siteKeyString = c.String(maxLength: 30),
                        isActive = c.Boolean(nullable: false),
                        creationTime = c.DateTimeOffset(nullable: false),
                        modificationTime = c.DateTimeOffset(),
                        deletionTime = c.DateTimeOffset(),
                        lockoutTime = c.DateTimeOffset(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Roles", t => t.roleId)
                .ForeignKey("dbo.Departments", t => t.departmentId)
                .ForeignKey("dbo.Addresses", t => t.addressId, cascadeDelete: true)
                .Index(t => t.roleId)
                .Index(t => t.departmentId)
                .Index(t => t.addressId);
            
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
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Departments",
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
                        zip = c.Int(nullable: false),
                        country = c.String(),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cardNumber = c.String(),
                        accountNumber = c.String(),
                        cvv = c.Int(nullable: false),
                        expirationDate = c.String(),
                        firstName = c.String(),
                        middleInitial = c.String(),
                        lastName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        question1 = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
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
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fromAccountNumber = c.String(),
                        fromRoutingNumber = c.String(),
                        toAccountNumber = c.String(),
                        toRoutingNumber = c.String(),
                        description = c.String(),
                        type = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        amount = c.Double(nullable: false),
                        processedTime = c.DateTimeOffset(nullable: false),
                        creationTime = c.DateTimeOffset(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.SecurityQuestions", new[] { "userId" });
            DropIndex("dbo.Users", new[] { "addressId" });
            DropIndex("dbo.Users", new[] { "departmentId" });
            DropIndex("dbo.Users", new[] { "roleId" });
            DropIndex("dbo.Accounts", new[] { "cardId" });
            DropIndex("dbo.Accounts", new[] { "userId" });
            DropForeignKey("dbo.SecurityQuestions", "userId", "dbo.Users");
            DropForeignKey("dbo.Users", "addressId", "dbo.Addresses");
            DropForeignKey("dbo.Users", "departmentId", "dbo.Departments");
            DropForeignKey("dbo.Users", "roleId", "dbo.Roles");
            DropForeignKey("dbo.Accounts", "cardId", "dbo.Cards");
            DropForeignKey("dbo.Accounts", "userId", "dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.SystemLogs");
            DropTable("dbo.Questions");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.Cards");
            DropTable("dbo.Addresses");
            DropTable("dbo.Departments");
            DropTable("dbo.SecurityQuestions");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Accounts");
        }
    }
}
