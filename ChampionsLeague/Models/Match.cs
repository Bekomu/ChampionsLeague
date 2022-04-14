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

        private Result _result;

        public Result Result
        {
            get { return _result; }
            set
            {
                if (Score1 > Score2)
                {
                    value = Result.Team1Won;
                }
                if (Score2 > Score1)
                {
                    value = Result.Team2Won;
                }
                else
                {
                    value = Result.Draw;
                }
                _result = value;
            }
        }

    }
}
