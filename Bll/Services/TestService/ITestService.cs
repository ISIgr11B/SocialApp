using Helpers.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bll.Services.TestService
{
    public interface ITestService
    {
        List<string> GetValues();
        Task<int> CreateValueAsync(TestBllModel test);
    }
}
