namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhieuThu", "GiamGia_MaGiamGia", "dbo.GiamGia");
            AddColumn("dbo.PhieuThu", "PhanTramGiam", c => c.Int(nullable: false));
            AddForeignKey("dbo.PhieuThu", "GiamGia_MaGiamGia", "dbo.GiamGia", "MaGiamGia");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuThu", "GiamGia_MaGiamGia", "dbo.GiamGia");
            DropColumn("dbo.PhieuThu", "PhanTramGiam");
            AddForeignKey("dbo.PhieuThu", "GiamGia_MaGiamGia", "dbo.GiamGia", "MaGiamGia", cascadeDelete: true);
        }
    }
}
