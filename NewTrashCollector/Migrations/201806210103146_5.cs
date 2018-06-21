namespace NewTrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "StopDate", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Schedules", "RestartDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "RestartDate", c => c.String());
            AlterColumn("dbo.Schedules", "StopDate", c => c.String());
        }
    }
}
