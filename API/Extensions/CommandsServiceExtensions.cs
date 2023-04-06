using Application.Commands.Addresses;
using Application.Commands.Addresses.Interfaces;

namespace API.Extensions
{
   public static class CommandsServiceExtensions
   {
      public static IServiceCollection AddCommandServices(this IServiceCollection services)
      {
         // Dependency Injection - Address Commands
         services.AddScoped<ICreateAddressCommand, CreateAddressCommand>();

         return services;
      }
   }
}