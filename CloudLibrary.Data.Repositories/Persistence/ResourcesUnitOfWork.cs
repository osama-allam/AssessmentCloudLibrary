using CloudLibrary.Data.Common.Persistence;
using CloudLibrary.Data.Core.Repositories.Contracts;

namespace CloudLibrary.Data.Core.Repositories.Persistence
{
    public class ResourcesUnitOfWork : UnitOfWorkBase, IResourcesUnitOfWork
    {
        public IDatabaseServerRepository DatabaseServerRepository { get; }
        public IVirtualMachineRepository VirtualMachineRepository { get; }
    }
}