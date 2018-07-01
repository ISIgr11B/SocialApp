using System;
using System.Collections.Generic;
using System.Text;
using Dal.Context;
using Dal.Entities;

namespace Dal.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>,IUserRepository
    {
        public UserRepository(MainDbContext context) : base(context)
        {
        }
    }
}
