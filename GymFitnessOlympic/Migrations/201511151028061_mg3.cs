namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GiamGia", "PhanTramGiam", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GiamGia", "PhanTramGiam", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
