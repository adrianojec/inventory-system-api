using Application.Commands.Addresses.Interfaces;
using Application.Core;
using Application.Repositories.AddressRepositories;

namespace Application.Commands.Addresses
{
   public class DeleteAddressCommand : IDeleteAddressCommand
   {
      private readonly IAddressRepository _addressRepository;
      public DeleteAddressCommand(IAddressRepository addressRepository)
      {
         _addressRepository = addressRepository;
      }
      public async Task<Result<bool>> ExecuteCommand(Guid id)
      {
         var address = await _addressRepository.GetById(id);

         if (address == null) return Result<bool>.Failure("No address found.");

         await _addressRepository.Delete(id);

         return Result<bool>.Success(true);
      }
   }
}