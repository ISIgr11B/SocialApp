using Dal.Context;
using Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vive.Vcs.Visualisation.Dal.VisualisationDbContext.Repositories;

namespace Dal.Repositories.TestRepository
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(MainDbContext context) : base(context)
        {
        }

        public void AddToTable(string name)
        {
            _context.Tests.Add(new Test() { Name = name });
        }
    }
}
