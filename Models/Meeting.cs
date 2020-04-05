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
        [Column(TypeName = "integer")]
        public int OpeningHymnNumber { get; set; }
        [Range(1, 341)]
        [Column(TypeName = "integer")]
        public string OpeningPrayer { get; set; }
        public string OpeningHymn { get; set; }
        [Range(1, 341)]
        public int SacramentHymnNumber { get; set; }
        public string SacramentHymn { get; set; }
        [Range(1, 341)]
        [Column(TypeName = "integer")]
        public int ClosingHymnNumber { get; set; }
        public string ClosingHymn { get; set; }
        public string ClosingPrayer { get; set; }

        //OPTIONAL FIELDS
        public string FirstSpeaker { get; set; }
        public string SecondSpeaker { get; set; }
        [Range(1, 341)]
        [Column(TypeName = "integer")]
        public int IntermediateHymnNumber { get; set; }
        public string IntermediateHymn { get; set; }
    }
}
