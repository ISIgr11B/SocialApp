using Dal.Context;
using System.Threading.Tasks;
using Dal.Repositories;

namespace Dal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainDbContext _context;

        public UnitOfWork(
            MainDbContext context,
            IFriendsRepository friendsRepository,
            IPhotoRepository photoRepository,
            IPostRepository postRepository,
            IUserRepository userRepository
            )
        {
            _context = context;
            FriendsRepository = friendsRepository;
            PhotoRepository = photoRepository;
            PostRepository = postRepository;
            UserRepository = userRepository;
        }

        public IFriendsRepository FriendsRepository { get; private set; }
        public IPhotoRepository PhotoRepository { get; private set; }
        public IPostRepository PostRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }


        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls
        

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);

            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}
