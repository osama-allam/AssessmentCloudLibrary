using CloudLibrary.Data.Common.Contracts;

namespace CloudLibrary.Data.Core.Repositories.Contracts
{
    public interface IResourcesUnitOfWork : IUnitOfWorkBase
    {
        IDatabaseServerRepository DatabaseServers { get; }
        IVirtualMachineRepository VirtualMachines { get; }
    }
}