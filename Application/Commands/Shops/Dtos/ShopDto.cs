using Domain;

namespace Application.Commands.Shops.Dtos
{
   public class ShopDto
   {
      public ShopDto(Shop shop)
      {
         Id = shop.Id;
         Name = shop.Name;
         Image = shop.Image;
         Location = shop.Location;
      }
      public Guid Id { get; set; }
      public String Name { get; set; } = string.Empty;
      public String Image { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;
   }
}