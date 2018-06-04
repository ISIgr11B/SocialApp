using System;
using System.Threading.Tasks;

namespace Dal.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        Task<int> CommitAsync();
    }
}
