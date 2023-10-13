using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string Sex { get; set; }
        public DateTime BandAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime BandUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
