using System;
using System.Collections.Generic;
using System.Text;
using Dal.Context;
using Dal.Entities;

namespace Dal.Repositories
{
    public class FriendsRepository : BaseRepository<FriendsEntity>,IFriendsRepository
    {
        public FriendsRepository(MainDbContext context) : base(context)
        {
        }
    }
}
