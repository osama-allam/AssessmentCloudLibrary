using System.Collections.Generic;
using CloudLibrary.Data.Common.Contracts.Entities;
using Newtonsoft.Json;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class CloudProvider : DirectoryEntity<string>
    {
        public CloudProvider()
        {
            Infrastructures = new HashSet<Infrastructure>();
        }
        [JsonIgnore]
        public virtual ICollection<Infrastructure> Infrastructures { get; set; }
    }
}