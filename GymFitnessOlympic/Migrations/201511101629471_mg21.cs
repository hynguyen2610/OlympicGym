namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachLe", "IsGYM", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachLe", "IsGYM");
        }
    }
}
