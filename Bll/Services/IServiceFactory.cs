using Bll.Services.ProfilesServices;
using Bll.Services.TestService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
    public interface IServiceFactory : IDisposable
    {
        ITestService TestService { get; }
        IPrivatePageService PrivatePageService {get;}
    }
}
