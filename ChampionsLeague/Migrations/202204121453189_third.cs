namespace ChampionsLeague.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Colors", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Colors", new[] { "Team_Id" });
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        Team_Id = c.Int(nullable: false),
                        Color_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_Id, t.Color_Id })
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: false)
                .ForeignKey("dbo.Colors", t => t.Color_Id, cascadeDelete: false)
                .Index(t => t.Team_Id)
                .Index(t => t.Color_Id);
            
            DropColumn("dbo.Colors", "Team_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Colors", "Team_Id", c => c.Int());
            DropForeignKey("dbo.TeamColors", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.TeamColors", "Team_Id", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "Color_Id" });
            DropIndex("dbo.TeamColors", new[] { "Team_Id" });
            DropTable("dbo.TeamColors");
            CreateIndex("dbo.Colors", "Team_Id");
            AddForeignKey("dbo.Colors", "Team_Id", "dbo.Teams", "Id");
        }
    }
}
