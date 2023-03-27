using Domain;
using Persistence;

namespace API.Extensions
{
   public static class IdentityServiceExtension
   {
      public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration config)
      {
         // Authorization and Authentication
         services.AddIdentityCore<User>(opt =>
         {
            opt.Password.RequireNonAlphanumeric = false;
            opt.User.RequireUniqueEmail = true;

         }).AddEntityFrameworkStores<DataContext>();

         services.AddAuthentication();

         return services;
      }
   }
}