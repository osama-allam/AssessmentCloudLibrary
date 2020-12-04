using System.Threading.Tasks;

namespace CloudLibrary.Data.Common
{
    public interface IUnitOfWork
    {
        
        int Complete();
        Task<int> CompleteAsync();
    }
}