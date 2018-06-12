namespace NewTrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        PickUpDay = c.String(),
                        SuspendPickUp = c.String(),
                        RestartPickUp = c.String(),
                        HasPaid = c.Boolean(nullable: false),
                        AddressId = c.Int(nullable: false),
                        InvoiceId = c.Int(nullable: false),
                        ScheduleId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.AddressId)
                .Index(t => t.InvoiceId)
                .Index(t => t.ScheduleId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        PickUpFrequency = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Customers", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Customers", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Customers", new[] { "ScheduleId" });
            DropIndex("dbo.Customers", new[] { "InvoiceId" });
            DropIndex("dbo.Customers", new[] { "AddressId" });
            DropIndex("dbo.Customers", new[] { "UserId" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
