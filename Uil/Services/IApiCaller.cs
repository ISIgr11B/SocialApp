using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Uil.Services
{
    public interface IApiCaller
    {
        Task<T> CallApi<T>(string accessToken, HttpMethodType httpMethodType, string requestUrl, HttpContent data = null);
    }
}
