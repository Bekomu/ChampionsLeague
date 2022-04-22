namespace ChampionsLeague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventh : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Matches", "Result");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "Result", c => c.Int(nullable: false));
        }
    }
}
