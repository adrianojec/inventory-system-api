using API.Controllers.Shops.InputModels;
using API.Controllers.Shops.ViewModels;
using Application.Commands.Shops.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Shops
{
   [ApiController]
   [Route("api/[controller]")]
   public class ShopsController : ControllerBase
   {
      private readonly ICreateShopCommand _createShopCommand;
      private readonly IGetShopsCommand _getShopsCommand;
      public ShopsController(
         ICreateShopCommand createShopCommand,
         IGetShopsCommand getShopsCommand
         )
      {
         _createShopCommand = createShopCommand;
         _getShopsCommand = getShopsCommand;
      }

      [HttpPost]
      public async Task<IActionResult> Create([FromBody] CreateShopInputModel input)
      {
         var result = await _createShopCommand.ExecuteCommand(input.ToCreateShopDto());

         if (!result.isSuccess) return BadRequest(result.Error);

         return Ok();
      }

      [HttpGet]
      public async Task<ActionResult<List<ShopViewModel>>> GetAll()
      {
         var shops = await _getShopsCommand.ExecuteCommand();

         if (!shops.isSuccess) return BadRequest(shops.Error);

         var data = shops.Value.Select(shop => new ShopViewModel(shop)).ToList();

         return Ok(data);
      }
   }
}