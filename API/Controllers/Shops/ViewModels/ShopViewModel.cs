using Application.Commands.Shops.Dtos;

namespace API.Controllers.Shops.ViewModels
{
   public class ShopViewModel
   {
      public ShopViewModel(ShopDto input)
      {
         Id = input.Id;
         Name = input.Name;
         Logo = input.Logo;
         ContactNumber = input.ContactNumber;
         EmailAddress = input.EmailAddress;
         Location = input.Location;
      }
      public Guid Id { get; set; }
      public String Name { get; set; } = string.Empty;
      public String Logo { get; set; } = string.Empty;
      public String ContactNumber { get; set; } = string.Empty;
      public String EmailAddress { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;
   }
}