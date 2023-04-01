using Domain;

namespace Application.Commands.Shops.Dtos
{
   public class CreateShopDto
   {
      public String Name { get; set; } = string.Empty;
      public String Image { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;

      public Shop ToShopEntity()
      {
         var shop = new Shop
         {
            Id = Guid.NewGuid(),
            Name = Name,
            Image = Image,
            Location = Location
         };

         return shop;
      }
   }
}