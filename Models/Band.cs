using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Band : IStatus
    {
        public int BandId { get; set; }
        public string BandName { get; set; }
        public int Formed { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Album> Albums { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
        public string ReasonForUpdating { get; set; }
       
    }
}
