using Application.Repositories.ShopRepositories;

namespace API.Extensions
{
   public static class RepositoriesServiceExtensions
   {
      public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
      {

         // Dependency Injection - Repository
         services.AddScoped<IShopRepository, ShopRepository>();

         return services;
      }
   }
}