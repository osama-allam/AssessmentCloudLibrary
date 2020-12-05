using System.Collections.Generic;
using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class Infrastructure : AuditEntity<int>  
    {
        public Infrastructure()
        {
            Resources = new HashSet<IResource>();
        }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<IResource> Resources { get; set; }

    }
}