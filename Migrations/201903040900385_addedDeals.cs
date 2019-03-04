namespace AgroFirmProgramm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDeals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Deal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroatsId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        GroatClass = c.Int(nullable: false),
                        GroatWhite = c.Double(nullable: false),
                        GroatHumidity = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbl_Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.tbl_Groats", t => t.GroatsId, cascadeDelete: true)
                .Index(t => t.GroatsId)
                .Index(t => t.ClientId);
            
            DropColumn("dbo.tbl_Groats", "Class");
            DropColumn("dbo.tbl_Groats", "White");
            DropColumn("dbo.tbl_Groats", "Humidity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_Groats", "Humidity", c => c.Double(nullable: false));
            AddColumn("dbo.tbl_Groats", "White", c => c.Double(nullable: false));
            AddColumn("dbo.tbl_Groats", "Class", c => c.Int(nullable: false));
            DropForeignKey("dbo.tbl_Deal", "GroatsId", "dbo.tbl_Groats");
            DropForeignKey("dbo.tbl_Deal", "ClientId", "dbo.tbl_Client");
            DropIndex("dbo.tbl_Deal", new[] { "ClientId" });
            DropIndex("dbo.tbl_Deal", new[] { "GroatsId" });
            DropTable("dbo.tbl_Deal");
        }
    }
}
