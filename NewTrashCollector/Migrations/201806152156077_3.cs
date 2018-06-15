namespace NewTrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Customer_CustomerId", c => c.Int());
            AlterColumn("dbo.Customers", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Customers", "UserId");
            CreateIndex("dbo.Customers", "Customer_CustomerId");
            AddForeignKey("dbo.Customers", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Customers", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Customers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Customers", new[] { "UserId" });
            AlterColumn("dbo.Customers", "UserId", c => c.String());
            DropColumn("dbo.Customers", "Customer_CustomerId");
        }
    }
}
