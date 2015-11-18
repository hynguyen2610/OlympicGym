namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanVien", "NgaySinh", c => c.DateTime(nullable: false));
            AddColumn("dbo.NhanVien", "IsKhoa", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanVien", "IsKhoa");
            DropColumn("dbo.NhanVien", "NgaySinh");
        }
    }
}
