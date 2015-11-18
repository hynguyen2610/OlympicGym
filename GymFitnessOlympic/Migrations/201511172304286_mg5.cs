namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SanPham", "MaVachSanPham", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SanPham", "MaVachSanPham", c => c.String());
        }
    }
}
