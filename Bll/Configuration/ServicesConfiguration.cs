using Bll.Services;
using Bll.Services.ProfilesServices;
using Dal.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Bll.Configuration
{
    public static class ServicesConfiguration{
        public static void ConfigureServices(this IServiceCollection services)
        {
            /*Repozytoria*/

            /*Serwisy */
            services.AddScoped<IServiceFactory, ServiceFactory>();
            services.AddScoped<IPrivatePageService, PrivatePageService>();
            services.AddScoped<IPersonInfoService, PersonInfoService>();

            /*UnitOfWork */
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
