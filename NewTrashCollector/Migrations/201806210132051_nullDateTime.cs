namespace NewTrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "StopDate", c => c.DateTime());
            AlterColumn("dbo.Schedules", "RestartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "RestartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Schedules", "StopDate", c => c.DateTime(nullable: false));
        }
    }
}
