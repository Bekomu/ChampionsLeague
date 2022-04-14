using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Models
{
    public class ChampionsDbContext : DbContext
    {
        public ChampionsDbContext() : base("name=CS")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<Match>()
                    .HasRequired(m => m.Team1)
                    .WithMany(t => t.HomeMatches)
                    .HasForeignKey(m => m.Team1Id)
                    .WillCascadeOnDelete(false);

            mb.Entity<Match>()
                        .HasRequired(m => m.Team2)
                        .WithMany(t => t.AwayMatches)
                        .HasForeignKey(m => m.Team2Id)
                        .WillCascadeOnDelete(false);
        }

    }
}
