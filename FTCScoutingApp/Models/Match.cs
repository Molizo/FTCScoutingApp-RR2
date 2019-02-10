using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FTCScoutingApp.Models
{
    public class Match
    {
        public int ID { get; set; }

        [Display(Name = "Blue Alliance Score")]
        public int BlueAllianceScore { get; set; }
        [Display(Name = "Red Alliance Score")]
        public int RedAllianceScore { get; set; }

        public string BlueTeam1ID { get; set; }
        public string BlueTeam2ID { get; set; }
        public string RedTeam1ID { get; set; }
        public string RedTeam2ID { get; set; }
    }
}
