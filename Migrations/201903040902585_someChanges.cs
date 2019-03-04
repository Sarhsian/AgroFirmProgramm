namespace AgroFirmProgramm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class someChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Deal", "Kilogram", c => c.Int(nullable: false));
            AddColumn("dbo.tbl_Deal", "TotalPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_Deal", "TotalPrice");
            DropColumn("dbo.tbl_Deal", "Kilogram");
        }
    }
}
