using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Game : IStatus
    {
        public int GameId { get; set; }
        public DateTime Added { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AddedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Updated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ReasonForUpdating { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime? IStatus.Updated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
