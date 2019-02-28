namespace AgroFirmProgramm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNulls : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_Client", "RoleId", "dbo.tbl_Role");
            DropIndex("dbo.tbl_Client", new[] { "RoleId" });
            AlterColumn("dbo.tbl_Client", "DateBirdth", c => c.DateTime());
            AlterColumn("dbo.tbl_Client", "PhoneNumber", c => c.Int());
            AlterColumn("dbo.tbl_User", "EndDate", c => c.DateTime());
            AlterColumn("dbo.tbl_Worker", "EndDate", c => c.DateTime());
            DropColumn("dbo.tbl_Client", "RoleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_Client", "RoleId", c => c.Int(nullable: false));
            AlterColumn("dbo.tbl_Worker", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tbl_User", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tbl_Client", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.tbl_Client", "DateBirdth", c => c.DateTime(nullable: false));
            CreateIndex("dbo.tbl_Client", "RoleId");
            AddForeignKey("dbo.tbl_Client", "RoleId", "dbo.tbl_Role", "Id", cascadeDelete: true);
        }
    }
}
