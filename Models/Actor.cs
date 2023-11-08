using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Actor : IStatus
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string Sex { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
        public string? ReasonForUpdating { get; set; }
        DateTime? IStatus.Updated { get; set; }
    }
}
