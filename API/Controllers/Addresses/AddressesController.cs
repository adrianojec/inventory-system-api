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
      private readonly IGetAddressCommand _getAddressCommand;
      public AddressesController
      (
         ICreateAddressCommand createAddressCommand,
         IGetAddressesCommand getAddressesCommand,
         IGetAddressCommand getAddressCommand
      )
      {
         _createAddressCommand = createAddressCommand;
         _getAddressesCommand = getAddressesCommand;
         _getAddressCommand = getAddressCommand;
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

      [HttpGet("{id}")]
      public async Task<ActionResult<AddressViewModel>> GetById([FromRoute] Guid id)
      {
         var address = await _getAddressCommand.ExecuteCommand(id);

         if (!address.isSuccess) return BadRequest(address.Error);

         return Ok(new AddressViewModel(address.Value));
      }
   }
}