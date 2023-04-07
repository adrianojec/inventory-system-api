using Application.Commands.Addresses.Dtos;
using Application.Core;

namespace Application.Commands.Addresses.Interfaces
{
   public interface IGetAddressCommand
   {
      Task<Result<AddressDto>> ExecuteCommand(Guid id);
   }
}