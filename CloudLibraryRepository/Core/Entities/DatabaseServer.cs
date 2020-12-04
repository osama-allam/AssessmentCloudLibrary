using CloudLibrary.Data.Common.Contracts;
using CloudLibrary.Data.Common.Core;
using CloudLibrary.Data.Common.Enum;

namespace CloudLibrary.Data.Entities.Core.Entities
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