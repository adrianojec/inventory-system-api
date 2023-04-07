using Application.Commands.Addresses.Dtos;
using Application.Commands.Addresses.Interfaces;
using Application.Core;
using Application.Repositories.AddressRepositories;

namespace Application.Commands.Addresses
{
   public class CreateAddressCommand : ICreateAddressCommand
   {
      private readonly IAddressRepository _addressRepository;
      public CreateAddressCommand(IAddressRepository addressRepository)
      {
         _addressRepository = addressRepository;

      }
      public async Task<Result<bool>> ExecuteCommand(CreateAddressDto input)
      {
         if (string.IsNullOrEmpty(input.Street)) return Result<bool>.Failure("Street is required.");
         if (input.ZipCode == 0) return Result<bool>.Failure("Zip code is invalid.");
         if (string.IsNullOrEmpty(input.City)) return Result<bool>.Failure("City is required.");

         await _addressRepository.Add(input.ToAddressEntity());

         return Result<bool>.Success(true);
      }
   }
}