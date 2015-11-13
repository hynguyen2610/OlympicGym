namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoiVien", "MaThe", c => c.String());
            DropColumn("dbo.HoiVien", "MaGYM");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HoiVien", "MaGYM", c => c.String());
            DropColumn("dbo.HoiVien", "MaThe");
        }
    }
}
