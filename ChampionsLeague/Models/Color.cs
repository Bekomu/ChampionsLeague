using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Models
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string ColorName { get; set; }

        [Required]
        public byte Red { get; set; }

        [Required]
        public byte Green { get; set; }

        [Required]
        public byte Blue { get; set; }

        public virtual ICollection<Models.Team> Teams { get; set; }

        public override string ToString()
        {
            return ColorName;
        }
    }
}
