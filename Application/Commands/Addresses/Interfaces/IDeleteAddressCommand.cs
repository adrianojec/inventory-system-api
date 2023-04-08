using Application.Core;

namespace Application.Commands.Addresses.Interfaces
{
   public interface IDeleteAddressCommand
   {
      Task<Result<bool>> ExecuteCommand(Guid id);
   }
}