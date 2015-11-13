namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HistoryHoiVien", "IsDaInGYM", c => c.Boolean(nullable: false));
            AddColumn("dbo.HistoryHoiVien", "IsDaInSauna", c => c.Boolean(nullable: false));
            DropColumn("dbo.HistoryHoiVien", "IsSauna");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HistoryHoiVien", "IsSauna", c => c.Boolean(nullable: false));
            DropColumn("dbo.HistoryHoiVien", "IsDaInSauna");
            DropColumn("dbo.HistoryHoiVien", "IsDaInGYM");
        }
    }
}
