using Bll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.TestService
{
    public interface ITestService
    {
        List<string> GetValues();
        Task<int> CreateValueAsync(TestBllModel test);
    }
}
