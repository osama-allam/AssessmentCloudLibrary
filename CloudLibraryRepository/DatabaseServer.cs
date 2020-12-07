using System.Collections.Generic;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Core.Entities
{
    public class DatabaseServer : Resource<string>
    {
        public override ResourceType Type => ResourceType.DataServer;
        public DbType DbType { get; set; }
        public string Version { get; set; }
        public Dictionary<string, string> AdditionalConfigurations { get; set; }
    }
}