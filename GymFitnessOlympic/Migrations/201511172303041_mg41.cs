namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg41 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SanPham", "MaVachSanPham", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SanPham", "MaVachSanPham");
        }
    }
}
