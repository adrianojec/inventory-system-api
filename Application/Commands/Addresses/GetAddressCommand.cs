using Application.Commands.Addresses.Dtos;
using Application.Commands.Addresses.Interfaces;
using Application.Core;
using Application.Repositories.AddressRepositories;

namespace Application.Commands.Addresses
{
   public class GetAddressCommand : IGetAddressCommand
   {
      private readonly IAddressRepository _addressRepository;
      public GetAddressCommand(IAddressRepository addressRepository)
      {
         _addressRepository = addressRepository;
      }
      public async Task<Result<AddressDto>> ExecuteCommand(Guid id)
      {
         var address = await _addressRepository.GetById(id);

         if (address == null) return Result<AddressDto>.Failure("No Address found.");

         return Result<AddressDto>.Success(new AddressDto(address));
      }
   }
}