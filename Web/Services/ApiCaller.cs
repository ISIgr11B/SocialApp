using Helpers;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Web.Configuration;

namespace Web.Services
{
    public class ApiCaller : IApiCaller
    {
        private readonly IOptions<SettingsConfiguration> _settingsConfiguration;
        private readonly string apiUrl;
        public ApiCaller(IOptions<SettingsConfiguration> settingsConfiguration)
        {
            _settingsConfiguration = settingsConfiguration;
            apiUrl = _settingsConfiguration.Value.ApiUrl;
        }

        public async Task<T> CallApi<T>(string accessToken, HttpMethodType httpMethodType, string requestUrl, HttpContent data = null)
        {
            HttpClient client = new HttpClient();
            //client.SetBearerToken(accessToken);
            client.BaseAddress = new Uri(_settingsConfiguration.Value.ApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage result;
                switch (httpMethodType)
                {
                    case HttpMethodType.GET:
                        result = await client.GetAsync(requestUrl);
                        break;
                    case HttpMethodType.POST:
                        result = await client.PostAsync(requestUrl, data);
                        break;
                    default:
                        return default(T);
                }
                string resultString = await result.Content.ReadAsStringAsync();
                string requestString = (data == null) ? "" : await data.ReadAsStringAsync();
                string fullApiCallString = "URL: " + requestUrl + " REQUEST: " + requestString + " RESPONSE: " + resultString;
                //_logService.SaveLog("VisualisationApiCalls", fullApiCallString);
                return JsonConvert.DeserializeObject<T>(resultString);
            }
            catch (Exception e)
            {
                //TODO logowanie
                return default(T);
            }
        }
    }
}
