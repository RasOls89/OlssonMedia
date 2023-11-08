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
    public class Movie : IStatus
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public bool StillOwn { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
        public string ReasonForUpdating { get; set; }
        DateTime IStatus.Added { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IStatus.AddedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime? IStatus.Updated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string? IStatus.UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string? IStatus.ReasonForUpdating { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
