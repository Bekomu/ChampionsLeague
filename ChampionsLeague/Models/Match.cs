using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Models
{
    [Table("Matches")]
    public class Match
    {
        public int Id { get; set; }

        [Required]
        public DateTime MatchTime { get; set; }

        [Required]
        public int Team1Id { get; set; }
        public virtual Team Team1 { get; set; }

        [Required]
        public int Team2Id { get; set; }
        public virtual Team Team2 { get; set; }

        public int? Score1 { get; set; }

        public int? Score2 { get; set; }

        public Result Result
        {
            get
            {
                if (Score1 == null || Score2 == null)
                {
                    return Result.NotPlayed;
                }
                if (Score1 > Score2)
                {
                    return Result.Team1Won;
                }
                if (Score2 > Score1)
                {
                    return Result.Team2Won;
                }
                
                else
                {
                    return Result.Draw;
                }
                
            }
        }

    }
}
