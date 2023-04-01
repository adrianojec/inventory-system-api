using Application.Commands.Shops.Dtos;

namespace API.Controllers.Shops.InputModels
{
   public class CreateShopInputModel
   {
      public String Name { get; set; } = string.Empty;
      public String Image { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;

      public CreateShopDto ToCreateShopDto()
      {
         var shop = new CreateShopDto
         {
            Name = Name,
            Image = Image,
            Location = Location
         };

         return shop;
      }
   }
}