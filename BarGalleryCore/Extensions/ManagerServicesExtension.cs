using BGBusinessLogic.Managers;
using BGBusinessLogic.Interfaces;

namespace BarGalleryCore.Extensions
{
    public static class ManagerServicesExtension
    {
        public static void AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped<IIdentityManager, IdentityManager>();
        }
    }
}
