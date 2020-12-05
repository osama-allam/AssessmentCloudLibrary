using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Core.Entities.Core.Entities
{
    public class DatabaseServer : Resource<int>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ResourceType Type => ResourceType.Database;
        public DbType DbType { get; set; }
        public string Version { get; set; }
    }
}