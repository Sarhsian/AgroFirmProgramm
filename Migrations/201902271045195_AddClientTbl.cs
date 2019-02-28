namespace AgroFirmProgramm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientTbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                        DateBirdth = c.DateTime(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Addres = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbl_Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_Client", "RoleId", "dbo.tbl_Role");
            DropIndex("dbo.tbl_Client", new[] { "RoleId" });
            DropTable("dbo.tbl_Client");
        }
    }
}
