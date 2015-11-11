namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.KhachLe", new[] { "NhanVien_MaNhanVien" });
            AlterColumn("dbo.KhachLe", "NhanVien_MaNhanVien", c => c.Int(nullable: false));
            CreateIndex("dbo.KhachLe", "NhanVien_MaNhanVien");
        }
        
        public override void Down()
        {
            DropIndex("dbo.KhachLe", new[] { "NhanVien_MaNhanVien" });
            AlterColumn("dbo.KhachLe", "NhanVien_MaNhanVien", c => c.Int());
            CreateIndex("dbo.KhachLe", "NhanVien_MaNhanVien");
        }
    }
}
