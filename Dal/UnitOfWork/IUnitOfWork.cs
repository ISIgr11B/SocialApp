using Dal.Repositories.TestRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITestRepository TestRepository { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}
