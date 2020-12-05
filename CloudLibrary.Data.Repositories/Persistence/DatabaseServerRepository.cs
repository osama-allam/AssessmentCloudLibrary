using CloudLibrary.Data.Common.Persistence.Repositories;
using CloudLibrary.Data.Core.Entities;
using CloudLibrary.Data.Core.Repositories.Contracts;

namespace CloudLibrary.Data.Core.Repositories.Persistence
{
    public class DatabaseServerRepository : Repository<DatabaseServer>, IDatabaseServerRepository
    {
        public DatabaseServerRepository(string root) : base(root)
        {
        }
        public string Root => _root;
    }
}