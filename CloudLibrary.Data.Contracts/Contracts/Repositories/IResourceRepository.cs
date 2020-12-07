using System.Collections.Generic;
using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Data.Common.Contracts.Repositories
{
    public interface IResourceRepository : IRepository<IResource<string>>
    {
    }
}