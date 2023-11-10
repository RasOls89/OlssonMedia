using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{/// <summary>
/// Model for albums
/// Has a many-to-one relationship to band
/// </summary>
    public class Album : IStatus
    {
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; } 
        public string BandName { get; set; }
        public string Band { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Format { get; set; }
        public bool StillOwn { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
        public string? ReasonForUpdating { get; set; }
        DateTime? IStatus.Updated { get; set; }
    }
}
