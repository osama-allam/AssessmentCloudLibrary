using System.Collections.Generic;
using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class Infrastructure : DirectoryEntity<string>  
    {
        public Infrastructure()
        {
            Resources = new HashSet<IResource<string>>();
        }
        public virtual ICollection<IResource<string>> Resources { get; set; }

    }
}