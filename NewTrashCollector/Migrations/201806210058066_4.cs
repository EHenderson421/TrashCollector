namespace NewTrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "StopDate", c => c.String());
            AlterColumn("dbo.Schedules", "RestartDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "RestartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Schedules", "StopDate", c => c.DateTime(nullable: false));
        }
    }
}
