﻿using System.Collections.Generic;
using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class CloudProvider : AuditEntity<int>, ICloudProvider
    {
        public CloudProvider()
        {
            Infrastructures = new HashSet<Infrastructure>();
        }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Infrastructure> Infrastructures { get; set; }
    }
}