using System.Collections.Generic;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Core.Entities.Core.Entities
{
    public class DatabaseServer : Resource<int>
    {
        public ResourceType Type => ResourceType.Database;
        public DbType DbType { get; set; }
        public string Version { get; set; }
        public Dictionary<string, string> AdditionalConfigurations { get; set; }
    }
}