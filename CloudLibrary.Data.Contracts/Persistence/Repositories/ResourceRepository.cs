using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Data.Common.Persistence.Repositories
{
    public class ResourceRepository : Repository<Resource<int>>, IResourceRepository 
    {
        
    }
}