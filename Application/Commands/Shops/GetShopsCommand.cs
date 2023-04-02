using Application.Commands.Shops.Dtos;
using Application.Commands.Shops.Interfaces;
using Application.Core;
using Application.Repositories.ShopRepositories;

namespace Application.Commands.Shops
{
   public class GetShopsCommand : IGetShopsCommand
   {
      private readonly IShopRepository _shopRepository;
      public GetShopsCommand(IShopRepository shopRepository)
      {
         _shopRepository = shopRepository;
      }
      public async Task<Result<List<ShopDto>>> ExecuteCommand()
      {
         var shops = await _shopRepository.GetAll();

         if (shops.Count == 0) return Result<List<ShopDto>>.Failure("There are no shops at the moment");

         var convertedShops = shops.Select(shop => new ShopDto(shop)).ToList();

         return Result<List<ShopDto>>.Success(convertedShops);
      }
   }
}