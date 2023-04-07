using Application.Commands.Addresses.Dtos;
using Application.Commands.Addresses.Interfaces;
using Application.Core;
using Application.Repositories.AddressRepositories;

namespace Application.Commands.Addresses
{
   public class GetAddressesCommand : IGetAddressesCommand
   {
      private readonly IAddressRepository _addressRepository;
      public GetAddressesCommand(IAddressRepository addressRepository)
      {
         _addressRepository = addressRepository;
      }
      public async Task<Result<List<AddressDto>>> ExecuteCommand()
      {
         var addresses = await _addressRepository.GetAll();

         if (addresses.Count == 0) return Result<List<AddressDto>>.Failure("No Addresses found.");

         var addressList = addresses.Select(address => new AddressDto(address)).ToList();

         return Result<List<AddressDto>>.Success(addressList);
      }
   }
}