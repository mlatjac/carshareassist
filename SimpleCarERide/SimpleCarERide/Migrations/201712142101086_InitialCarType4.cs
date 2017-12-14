namespace SimpleCarERide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCarType4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarTypes", "ShortName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarTypes", "ShortName");
        }
    }
}
