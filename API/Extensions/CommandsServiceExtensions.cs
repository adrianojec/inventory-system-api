using Application.Commands.Shops;
using Application.Commands.Shops.Interfaces;

namespace API.Extensions
{
   public static class CommandsServiceExtensions
   {
      public static IServiceCollection AddCommandServices(this IServiceCollection services)
      {
         // Shop Commands
         services.AddScoped<ICreateShopCommand, CreateShopCommand>();

         return services;
      }
   }
}