using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Models
{
    [Table("Teams")]
    public class Team
    {
        public Team()
        {
            Colors = new List<Color>();
        }
        public int Id { get; set; }

        [Required]
        public string TeamName { get; set; }

        public virtual ICollection<Models.Color> Colors { get; set; }
        public virtual ICollection<Match> HomeMatches { get; set; }
        public virtual ICollection<Match> AwayMatches { get; set; }
        public override string ToString()
        {
            return TeamName;
        }
    }
}
