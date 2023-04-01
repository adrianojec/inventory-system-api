using Application.Commands.Shops.Dtos;
using Application.Core;

namespace Application.Commands.Shops.Interfaces
{
   public interface ICreateShopCommand
   {
      Task<Result<bool>> ExecuteCommand(CreateShopDto input);
   }
}