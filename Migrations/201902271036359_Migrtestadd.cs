namespace AgroFirmProgramm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrtestadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Roles = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbl_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        DateBirdth = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbl_Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tbl_Worker",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                        DateBirdth = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Addres = c.String(nullable: false),
                        Wage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbl_Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_Worker", "RoleId", "dbo.tbl_Role");
            DropForeignKey("dbo.tbl_User", "RoleId", "dbo.tbl_Role");
            DropIndex("dbo.tbl_Worker", new[] { "RoleId" });
            DropIndex("dbo.tbl_User", new[] { "RoleId" });
            DropTable("dbo.tbl_Worker");
            DropTable("dbo.tbl_User");
            DropTable("dbo.tbl_Role");
        }
    }
}
