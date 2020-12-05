using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Data.Common.Persistence.Repositories
{
    public class StorageProfileRepository : Repository<StorageProfile>, IStorageProfileRepository
    {
        public StorageProfileRepository(string root) : base(root)
        {
        }
        public string Root => _root;
    }
}