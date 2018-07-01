using Bll.Services;
using Bll.Services.ProfilesServices;
using Dal.Repositories;
using Dal.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Bll.Configuration
{
    public static class ServicesConfiguration{
        public static void ConfigureServices(this IServiceCollection services)
        {
            /*Repozytoria*/
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IFriendsRepository, FriendsRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            /*Serwisy */
            services.AddScoped<IServiceFactory, ServiceFactory>();
            //services.AddScoped<IPrivatePageService, PrivatePageServiceMemory>();
            services.AddScoped<IPrivatePageService, PrivatePageService>();
            services.AddScoped<IPersonInfoService, PersonInfoService>();

            /*UnitOfWork */
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
