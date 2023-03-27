using API.Controllers.Users.InputModels;
using API.Controllers.Users.ViewModels;
using API.Services;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Users
{
   [ApiController]
   [Route("api/[controller]")]

   public class UsersController : ControllerBase
   {
      private readonly UserManager<User> _userManager;
      private readonly TokenService _tokenService;
      public UsersController(UserManager<User> userManager, TokenService tokenService)
      {
         _tokenService = tokenService;
         _userManager = userManager;
      }

      [AllowAnonymous]
      [HttpPost("register")]
      public async Task<ActionResult<UserViewModel>> register([FromBody] RegisterUserInputModel input)
      {
         if (await _userManager.Users.AnyAsync(user => user.UserName == input.UserName))
         {
            return BadRequest("Username is already taken.");
         }

         if (await _userManager.Users.AnyAsync(user => user.Email == input.Email))
         {
            return BadRequest("Email is already taken.");
         }

         var user = input.ToUserEntity();

         var result = await _userManager.CreateAsync(user, input.Password);

         if (!result.Succeeded) return BadRequest(result.Errors);

         var token = _tokenService.CreateToken(user);

         System.Console.WriteLine(token);

         return new UserViewModel(user.UserName, token);
      }
   }
}