using CloudLibrary.Data.Common.Persistence;
using CloudLibrary.Data.Core.Repositories.Contracts;

namespace CloudLibrary.Data.Core.Repositories.Persistence
{
    public class ResourcesUnitOfWork : UnitOfWorkBase, IResourcesUnitOfWork
    {
        public IDatabaseServerRepository DatabaseServers { get; }
        public IVirtualMachineRepository VirtualMachines { get; }
        public string Root => _root;
        public ResourcesUnitOfWork(string root) : base(root)
        {
            DatabaseServers = new DatabaseServerRepository(_root);
            VirtualMachines = new VirtualMachineRepository(_root);
        }
    }
}