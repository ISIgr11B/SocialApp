using System;
using System.Threading.Tasks;
using Dal.Repositories;

namespace Dal.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IFriendsRepository FriendsRepository { get; }
        IPhotoRepository PhotoRepository { get; }
        IPostRepository PostRepository { get; }
        IUserRepository UserRepository { get; }

        int Commit();
        Task<int> CommitAsync();
    }
}
