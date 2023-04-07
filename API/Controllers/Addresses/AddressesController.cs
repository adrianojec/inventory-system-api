using API.Controllers.Addresses.InputModels;
using Application.Commands.Addresses.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Addresses
{
   [ApiController]
   [Route("api/[controller]")]
   public class AddressesController : ControllerBase
   {
      private readonly ICreateAddressCommand _createAddressCommand;
      private readonly IGetAddressesCommand _getAddressesCommand;
      public AddressesController
      (
         ICreateAddressCommand createAddressCommand,
         IGetAddressesCommand getAddressesCommand
      )
      {
         _createAddressCommand = createAddressCommand;
         _getAddressesCommand = getAddressesCommand;
      }

      [HttpPost]
      public async Task<ActionResult> Create([FromBody] CreateAddressInputModel input)
      {
         var address = await _createAddressCommand.ExecuteCommand(input.ToCreateAddressDto());

         if (!address.isSuccess) return BadRequest(address.Error);

         return Ok();
      }

      [HttpGet]
      public async Task<ActionResult<List<AddressViewModel>>> GetAll()
      {
         var addresses = await _getAddressesCommand.ExecuteCommand();

         if (!addresses.isSuccess) return BadRequest(addresses.Error);

         var addressList = addresses.Value.Select(address => new AddressViewModel(address)).ToList();

         return Ok(addressList);
      }
   }
}