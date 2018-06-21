namespace NewTrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extraPickUp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "ExtraPickUp", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schedules", "ExtraPickUp");
        }
    }
}
