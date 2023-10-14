using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Band
    {
        public int BandId { get; set; }
        public string BandName { get; set; }
        public int Formed { get; set; }
        public bool IsActive { get; set; }
        public DateTime BandAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime BandUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public ICollection<Music> Albums { get; set; }
    }
}
