using System;
using System.Collections.Generic;
using System.Text;
using Dal.Context;
using Dal.Entities;

namespace Dal.Repositories
{
    public class PostRepository : BaseRepository<PostEntity>,IPostRepository
    {
        public PostRepository(MainDbContext context) : base(context)
        {
        }
    }
}
