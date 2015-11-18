namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg32 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HistoryHoiVien", "PhongTap_MaPhongTap", c => c.Int());
            CreateIndex("dbo.HistoryHoiVien", "PhongTap_MaPhongTap");
            AddForeignKey("dbo.HistoryHoiVien", "PhongTap_MaPhongTap", "dbo.PhongTap", "MaPhongTap");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistoryHoiVien", "PhongTap_MaPhongTap", "dbo.PhongTap");
            DropIndex("dbo.HistoryHoiVien", new[] { "PhongTap_MaPhongTap" });
            DropColumn("dbo.HistoryHoiVien", "PhongTap_MaPhongTap");
        }
    }
}
