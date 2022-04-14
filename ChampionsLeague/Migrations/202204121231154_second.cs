namespace ChampionsLeague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ColorTeams", newName: "TeamColors");
            DropPrimaryKey("dbo.TeamColors");
            AddPrimaryKey("dbo.TeamColors", new[] { "Team_Id", "Color_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TeamColors");
            AddPrimaryKey("dbo.TeamColors", new[] { "Color_Id", "Team_Id" });
            RenameTable(name: "dbo.TeamColors", newName: "ColorTeams");
        }
    }
}
