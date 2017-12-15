namespace CarSharing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTables : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Loans", name: "Member_ID", newName: "UserMember_ID");
            RenameIndex(table: "dbo.Loans", name: "IX_Member_ID", newName: "IX_UserMember_ID");
            AddColumn("dbo.Loans", "MemberId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loans", "MemberId");
            RenameIndex(table: "dbo.Loans", name: "IX_UserMember_ID", newName: "IX_Member_ID");
            RenameColumn(table: "dbo.Loans", name: "UserMember_ID", newName: "Member_ID");
        }
    }
}
