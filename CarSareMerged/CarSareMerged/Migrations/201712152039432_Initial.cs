namespace CarSareMerged.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShortName = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        TagLine = c.String(nullable: false),
                        FullDescription = c.String(nullable: false),
                        RatePerMinute = c.Double(nullable: false),
                        RatePerHour = c.Double(nullable: false),
                        RatePerDay = c.Double(nullable: false),
                        ImageReference = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarTypes");
        }
    }
}
