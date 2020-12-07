using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Entities;

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