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
      public AddressesController(ICreateAddressCommand createAddressCommand)
      {
         _createAddressCommand = createAddressCommand;
      }

      [HttpPost]
      public async Task<ActionResult> Create([FromBody] CreateAddressInputModel input)
      {
         var address = await _createAddressCommand.ExecuteCommand(input.ToCreateAddressDto());

         if (!address.isSuccess) return BadRequest(address.Error);

         return Ok();
      }
   }
}