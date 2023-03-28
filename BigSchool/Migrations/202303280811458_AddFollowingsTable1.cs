namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "isShowGoing", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "isShowGoing");
        }
    }
}
