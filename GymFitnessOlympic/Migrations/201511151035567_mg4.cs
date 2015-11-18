namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhieuThu", "GiamGia_MaGiamGia", c => c.String(maxLength: 128));
            AddColumn("dbo.KhachLe", "GiamGia_MaGiamGia", c => c.String(maxLength: 128));
            CreateIndex("dbo.PhieuThu", "GiamGia_MaGiamGia");
            CreateIndex("dbo.KhachLe", "GiamGia_MaGiamGia");
            AddForeignKey("dbo.KhachLe", "GiamGia_MaGiamGia", "dbo.GiamGia", "MaGiamGia", cascadeDelete: true);
            AddForeignKey("dbo.PhieuThu", "GiamGia_MaGiamGia", "dbo.GiamGia", "MaGiamGia", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuThu", "GiamGia_MaGiamGia", "dbo.GiamGia");
            DropForeignKey("dbo.KhachLe", "GiamGia_MaGiamGia", "dbo.GiamGia");
            DropIndex("dbo.KhachLe", new[] { "GiamGia_MaGiamGia" });
            DropIndex("dbo.PhieuThu", new[] { "GiamGia_MaGiamGia" });
            DropColumn("dbo.KhachLe", "GiamGia_MaGiamGia");
            DropColumn("dbo.PhieuThu", "GiamGia_MaGiamGia");
        }
    }
}
