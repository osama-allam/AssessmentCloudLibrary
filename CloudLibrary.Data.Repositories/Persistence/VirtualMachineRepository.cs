using CloudLibrary.Data.Common.Persistence.Repositories;
using CloudLibrary.Data.Core.Entities;
using CloudLibrary.Data.Core.Repositories.Contracts;

namespace CloudLibrary.Data.Core.Repositories.Persistence
{
    public class VirtualMachineRepository : Repository<VirtualMachine>, IVirtualMachineRepository
    {
        public VirtualMachineRepository(string root) : base(root)
        {
        }
        public string Root => _root;
    }
}