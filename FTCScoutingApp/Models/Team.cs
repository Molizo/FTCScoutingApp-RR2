using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FTCScoutingApp.Models
{
    public class Team
    {
        [Key]
        public int ID { get; set; }
        public int EventID { get; set; }
        [Display(Name = "Team ID")]
        public int TeamID { get; set; }
        [Display(Name = "Team name")]
        public string TeamName { get; set; }
        [Display(Name = "Team country")]
        public string TeamCountry { get; set; }

        [Display(Name = "Start location")]
        public string StartLocation { get; set; }
        [Display(Name = "End location")]
        public string EndLocation { get; set; }

        [Display(Name = "Autonomy")]
        public bool Autonomy { get; set; }
        [Display(Name = "Latched")]
        public bool Latched { get; set; }
        [Display(Name = "Sampling")]
        public bool Sampling { get; set; }
        [Display(Name = "Team Marker")]
        public bool TeamMarker { get; set; }
        [Display(Name = "Parking")]
        public bool Parking { get; set; }

        [Display(Name = "Comments")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public string AllowedUserIDs { get; set; }
    }
}
