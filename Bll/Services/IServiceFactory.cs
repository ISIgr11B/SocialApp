using Bll.Services.ProfilesServices;
using System;

namespace Bll.Services
{
    public interface IServiceFactory : IDisposable
    {
        IPrivatePageService PrivatePageService {get;}
        IPersonInfoService PersonInfoService { get; }
    }
}
