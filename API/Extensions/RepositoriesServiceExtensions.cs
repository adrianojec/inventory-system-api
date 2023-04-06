using Application.Repositories.AddressRepositories;

namespace API.Extensions
{
   public static class RepositoriesServiceExtensions
   {
      public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
      {

         // Dependency Injection - Repository
         services.AddScoped<IAddressRepository, AddressRepository>();

         return services;
      }
   }
}