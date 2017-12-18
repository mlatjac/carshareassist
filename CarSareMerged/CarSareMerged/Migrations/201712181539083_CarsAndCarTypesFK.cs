namespace CarSareMerged.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarsAndCarTypesFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarTypeID", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "currentPositionLat", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "currentPositionLon", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "currentOdometerReading", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "currentFuelStatus", c => c.Double(nullable: false));
            CreateIndex("dbo.Cars", "CarTypeID");
            AddForeignKey("dbo.Cars", "CarTypeID", "dbo.CarTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarTypeID", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "CarTypeID" });
            DropColumn("dbo.Cars", "currentFuelStatus");
            DropColumn("dbo.Cars", "currentOdometerReading");
            DropColumn("dbo.Cars", "currentPositionLon");
            DropColumn("dbo.Cars", "currentPositionLat");
            DropColumn("dbo.Cars", "CarTypeID");
        }
    }
}
