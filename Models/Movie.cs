using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Class for the movies
    /// Has many-to-many with actor
    /// </summary>
    public class Movie
    {
        public int MovieId { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public DateTime MovieAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime MovieUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
