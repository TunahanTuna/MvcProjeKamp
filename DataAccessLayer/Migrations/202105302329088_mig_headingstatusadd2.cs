namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_headingstatusadd2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "headingStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Headings", "headinhStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "headinhStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Headings", "headingStatus");
        }
    }
}
