namespace ChampionsLeague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.Byte(nullable: false),
                        Team1Id = c.Int(nullable: false),
                        Team2Id = c.Int(nullable: false),
                        Score1 = c.Int(nullable: false),
                        Score2 = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team1Id)
                .ForeignKey("dbo.Teams", t => t.Team2Id)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false, maxLength: 20),
                        Red = c.Byte(nullable: false),
                        Green = c.Byte(nullable: false),
                        Blue = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(nullable: false, maxLength: 50),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.ColorTeams",
                c => new
                    {
                        Color_Id = c.Int(nullable: false),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Color_Id, t.Team_Id })
                .ForeignKey("dbo.Colors", t => t.Color_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Color_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropForeignKey("dbo.ColorTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.ColorTeams", "Color_Id", "dbo.Colors");
            DropIndex("dbo.ColorTeams", new[] { "Team_Id" });
            DropIndex("dbo.ColorTeams", new[] { "Color_Id" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            DropIndex("dbo.Matches", new[] { "Team1Id" });
            DropTable("dbo.ColorTeams");
            DropTable("dbo.Players");
            DropTable("dbo.Colors");
            DropTable("dbo.Teams");
            DropTable("dbo.Matches");
        }
    }
}
