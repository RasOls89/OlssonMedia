using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Internals
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Roll { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string AcessRights { get; set; }
        public DateTime UserAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime UserUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public int ReasonForUpdating { get; set; }
    }
}
