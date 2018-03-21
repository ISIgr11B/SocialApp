using Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vive.Vcs.Visualisation.Dal.VisualisationDbContext.Repositories;

namespace Dal.Repositories.TestRepository
{
    public interface ITestRepository :IBaseRepository<Test>
    {
    }
}
