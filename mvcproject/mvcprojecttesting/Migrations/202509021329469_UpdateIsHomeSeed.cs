namespace mvcprojecttesting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIsHomeSeed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "IsHome", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "IsHome");
        }
    }
}
