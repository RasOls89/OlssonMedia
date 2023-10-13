using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{/// <summary>
/// Model for the music
/// Has a many-to-one relationship to band
/// </summary>
    public class Music
    {
        public int MusicId { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Format { get; set; }
        public DateTime MusicAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime MusicUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
