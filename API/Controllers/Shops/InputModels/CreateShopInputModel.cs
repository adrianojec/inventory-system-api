using Application.Commands.Shops.Dtos;

namespace API.Controllers.Shops.InputModels
{
   public class CreateShopInputModel
   {
      public String Name { get; set; } = string.Empty;
      public String Logo { get; set; } = string.Empty;
      public String ContactNumber { get; set; } = string.Empty;
      public String EmailAddress { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;

      public CreateShopDto ToCreateShopDto()
      {
         var shop = new CreateShopDto
         {
            Name = Name,
            Logo = Logo,
            ContactNumber = ContactNumber,
            EmailAddress = EmailAddress,
            Location = Location
         };

         return shop;
      }
   }
}