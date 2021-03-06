namespace AgroFirmProgramm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGroats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Groats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Class = c.Int(nullable: false),
                        White = c.Double(nullable: false),
                        Humidity = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Groats");
        }
    }
}
