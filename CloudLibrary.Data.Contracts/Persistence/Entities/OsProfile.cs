using System.Collections.Generic;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class OsProfile : AuditEntity<string>
    {
        public OsType Type { get; set; }
        public string ComputerName { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> Configurations { get; set; }
        public bool AllowGuest { get; set; }
    }
}