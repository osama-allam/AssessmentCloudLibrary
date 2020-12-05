using CloudLibrary.Data.Common.Contracts.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class DirectoryEntity<T> : AuditEntity<T>, IDirectoryEntity<T> where T : class
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}