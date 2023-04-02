using Application.Commands.Shops.Dtos;
using Application.Commands.Shops.Interfaces;
using Application.Core;
using Application.Repositories.ShopRepositories;

namespace Application.Commands.Shops
{
   public class CreateShopCommand : ICreateShopCommand
   {
      private readonly IShopRepository _shopRepository;
      public CreateShopCommand(IShopRepository shopRepository)
      {
         _shopRepository = shopRepository;
      }
      public async Task<Result<bool>> ExecuteCommand(CreateShopDto input)
      {
         if (string.IsNullOrEmpty(input.Name)) return Result<bool>.Failure("Shop Name is required");
         if (string.IsNullOrEmpty(input.Location)) return Result<bool>.Failure("Shop Location is required");
         if (string.IsNullOrEmpty(input.ContactNumber) && string.IsNullOrEmpty(input.EmailAddress)) return Result<bool>.Failure("Contact Number or Email Address must be provided");

         _shopRepository.Add(input.ToShopEntity());
         await _shopRepository.SaveChangesAsync();

         return Result<bool>.Success(true);
      }
   }
}