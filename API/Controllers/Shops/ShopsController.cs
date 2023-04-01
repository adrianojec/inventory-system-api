using API.Controllers.Shops.InputModels;
using Application.Commands.Shops.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Shops
{
   [ApiController]
   [Route("api/[controller]")]
   public class ShopsController : ControllerBase
   {
      private readonly ICreateShopCommand _createShopCommand;
      public ShopsController(ICreateShopCommand createShopCommand)
      {
         _createShopCommand = createShopCommand;
      }

      [HttpPost]
      public async Task<IActionResult> Create([FromBody] CreateShopInputModel input)
      {
         var result = await _createShopCommand.ExecuteCommand(input.ToCreateShopDto());

         if (!result.isSuccess) return BadRequest(result.Error);

         return Ok();
      }
   }
}