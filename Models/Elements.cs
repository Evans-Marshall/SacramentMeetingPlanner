using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Elements
    {
        public Guid ID { get; set; }
        public string MeetingId { get; set; }
        public string Type { get; set; }
        
        public string Assignment { get; set; }
        public int HymnNumber { get; set; }
        
    }
}
