namespace ChampionsLeague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "MatchTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "MatchTime", c => c.Byte(nullable: false));
        }
    }
}
