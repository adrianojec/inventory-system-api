using Application.Commands.Shops.Dtos;
using Application.Core;

namespace Application.Commands.Shops.Interfaces
{
   public interface IGetShopsCommand
   {
      Task<Result<List<ShopDto>>> ExecuteCommand();
   }
}