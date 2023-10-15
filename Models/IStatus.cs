using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal interface IStatus
    {
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
        public string ReasonForUpdating { get; set; }
      
    }
}
