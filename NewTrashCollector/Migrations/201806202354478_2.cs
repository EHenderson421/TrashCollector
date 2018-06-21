namespace NewTrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "StopDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Schedules", "RestartDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Schedules", "SuspendPickUp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "SuspendPickUp", c => c.Boolean(nullable: false));
            DropColumn("dbo.Schedules", "RestartDate");
            DropColumn("dbo.Schedules", "StopDate");
        }
    }
}
