namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanVien", "IsConLamViec", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanVien", "IsConLamViec");
        }
    }
}
