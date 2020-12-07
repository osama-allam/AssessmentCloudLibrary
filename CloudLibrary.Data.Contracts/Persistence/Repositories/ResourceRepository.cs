using System.Collections.Generic;
using System.IO;
using System.Linq;
using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Entities;
using Newtonsoft.Json;

namespace CloudLibrary.Data.Common.Persistence.Repositories
{
    public class ResourceRepository : Repository<IResource<string>>, IResourceRepository 
    {
        public ResourceRepository(string root) : base(root)
        {
        }
        public string Root => _root;
    }
}