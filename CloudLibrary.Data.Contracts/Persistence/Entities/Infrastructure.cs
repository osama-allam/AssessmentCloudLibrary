using System.Collections.Generic;
using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class Infrastructure : DirectoryEntity<string>  
    {
        public Infrastructure()
        {
            Resources = new HashSet<IResource>();
        }
        public virtual ICollection<IResource> Resources { get; set; }

    }
}