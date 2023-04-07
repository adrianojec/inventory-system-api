using Application.Commands.Addresses.Dtos;
using Application.Core;

namespace Application.Commands.Addresses.Interfaces
{
   public interface ICreateAddressCommand
   {
      Task<Result<bool>> ExecuteCommand(CreateAddressDto input);
   }
}