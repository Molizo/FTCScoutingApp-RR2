using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FTCScoutingApp.Models
{
    public class Event
    {
        public int ID { get; set; }
        [Display(Name = "Event name")]
        public string EventName { get; set; }

        [Display(Name = "Matches Played")]
        public int MatchesPlayed { get; set; }

        public string GamesPlayed { get; set; }
    }
}
