using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public Guid MeetingID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Conducting { get; set; }

        [Range(1, 341)]
        public int OpeningHymnNumber { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Range(1, 341)]
        public int SacramentHymnNumber { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Range(1, 341)]
        public int ClosingHymnNumber { get; set; }

        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

        [Display(Name = "First Speaker")]
        public string FirstSpeaker { get; set; }

        [Display(Name = "Second Speaker")]
        public string SecondSpeaker { get; set; }

        [Range(1, 341)]
        public int IntermediateHymnNumber { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public string IntermediateHymn { get; set; }
    }
}
