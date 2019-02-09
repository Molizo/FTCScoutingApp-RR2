using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FTCScoutingApp.Models
{
    public class Team
    {
        public int ID { get; set; }
        [Display(Name = "Team Number")]
        public string TeamID { get; set; }
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
            
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Ties { get; set; }

        [Display(Name = "Robot starts latched")]
        public bool StartsLatched { get; set; }
        [Display(Name = "Robot prefers starting at crater")]
        public bool PrefersStartingCrater { get; set; }

        [Display(Name = "Problems with robot")]
        [DataType(DataType.MultilineText)]
        public string KnownRobotProblems { get; set; }

        [Display(Name = "Robot has autonomy")]
        public bool HasAutonomy { get; set; }
        [Display(Name = "Robot moves gold mineral")]
        public bool MovesGoldMineral { get; set; }
        [Display(Name = "Robot places team marker")]
        public bool PlacesTeamMarker { get; set; }
        [Display(Name = "Robot parks in crater")]
        public bool ParksInCrater { get; set; }
    }
}
