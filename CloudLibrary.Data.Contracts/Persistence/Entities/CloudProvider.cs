using System.Collections.Generic;
using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class CloudProvider : DirectoryEntity<string>
    {
        public CloudProvider()
        {
            Infrastructures = new HashSet<Infrastructure>();
        }
        public virtual ICollection<Infrastructure> Infrastructures { get; set; }
    }
}