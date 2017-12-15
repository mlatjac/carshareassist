namespace CarSharing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        ActualStartTime = c.DateTime(nullable: false),
                        ActualEndTime = c.DateTime(nullable: false),
                        Car_ID = c.Int(),
                        Member_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cars", t => t.Car_ID)
                .ForeignKey("dbo.Members", t => t.Member_ID)
                .Index(t => t.Car_ID)
                .Index(t => t.Member_ID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        Lname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loans", "Member_ID", "dbo.Members");
            DropForeignKey("dbo.Loans", "Car_ID", "dbo.Cars");
            DropIndex("dbo.Loans", new[] { "Member_ID" });
            DropIndex("dbo.Loans", new[] { "Car_ID" });
            DropTable("dbo.Members");
            DropTable("dbo.Loans");
            DropTable("dbo.Cars");
        }
    }
}
