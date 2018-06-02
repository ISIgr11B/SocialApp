using Bll.Services;
using Bll.Services.ProfilesServices;
using Bll.Services.TestService;
using Dal.Repositories.TestRepository;
using Dal.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Bll.Configuration
{
    public static class ServicesConfiguration{
        public static void ConfigureServices(this IServiceCollection services)
        {
            /*Repozytoria*/
            services.AddScoped<ITestRepository, TestRepository>();

            /*Serwisy */
            services.AddScoped<IServiceFactory, ServiceFactory>();
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<IPrivatePageService, PrivatePageService>();
            services.AddScoped<IPersonInfoService, PersonInfoService>();

            /*UnitOfWork */
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
