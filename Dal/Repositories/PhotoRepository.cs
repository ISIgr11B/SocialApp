using System;
using System.Collections.Generic;
using System.Text;
using Dal.Context;
using Dal.Entities;

namespace Dal.Repositories
{
    public class PhotoRepository : BaseRepository<PhotoEntity>, IPhotoRepository
    {
        public PhotoRepository(MainDbContext context) : base(context)
        {
        }
    }
}
