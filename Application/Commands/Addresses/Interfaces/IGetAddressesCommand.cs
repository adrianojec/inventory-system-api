using Application.Commands.Addresses.Dtos;
using Application.Core;

namespace Application.Commands.Addresses.Interfaces
{
   public interface IGetAddressesCommand
   {
      Task<Result<List<AddressDto>>> ExecuteCommand();
   }
}