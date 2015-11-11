namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachLe", "NhanVien_MaNhanVien", c => c.Int());
            CreateIndex("dbo.KhachLe", "NhanVien_MaNhanVien");
            AddForeignKey("dbo.KhachLe", "NhanVien_MaNhanVien", "dbo.NhanVien", "MaNhanVien", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KhachLe", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropIndex("dbo.KhachLe", new[] { "NhanVien_MaNhanVien" });
            DropColumn("dbo.KhachLe", "NhanVien_MaNhanVien");
        }
    }
}
