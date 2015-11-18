namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg42 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HistoryHoiVien", "PhongTap_MaPhongTap", "dbo.PhongTap");
            DropIndex("dbo.HistoryHoiVien", new[] { "PhongTap_MaPhongTap" });
            DropColumn("dbo.HistoryHoiVien", "PhongTap_MaPhongTap");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HistoryHoiVien", "PhongTap_MaPhongTap", c => c.Int());
            CreateIndex("dbo.HistoryHoiVien", "PhongTap_MaPhongTap");
            AddForeignKey("dbo.HistoryHoiVien", "PhongTap_MaPhongTap", "dbo.PhongTap", "MaPhongTap");
        }
    }
}
