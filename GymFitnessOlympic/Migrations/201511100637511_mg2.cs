namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoiVien", "NgayGioDangKy", c => c.DateTime(nullable: false));
            AddColumn("dbo.HoiVien", "IsDangKyNhanh", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoiVien", "IsDangKyNhanh");
            DropColumn("dbo.HoiVien", "NgayGioDangKy");
        }
    }
}
