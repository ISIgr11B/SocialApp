using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.Models;
using Dal.Entities;
using Dal.UnitOfWork;

namespace Bll.Services.TestService
{
    public class TestService : ServiceBase, ITestService
    {
        public TestService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<int> CreateValueAsync(TestBllModel test)
        {
            var entry = new Test { Name = test.Value };
            _unitOfWork.TestRepository.AddAsync(entry);

            return _unitOfWork.CommitAsync();
        }

        public List<string> GetValues()
        {
            return _unitOfWork.TestRepository.GetAll().Select(x => x.Name).ToList();
        }
    }
}
