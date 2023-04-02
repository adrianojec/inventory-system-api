using Domain;

namespace Application.Commands.Shops.Dtos
{
   public class ShopDto
   {
      public ShopDto(Shop shop)
      {
         Id = shop.Id;
         Name = shop.Name;
         Logo = shop.Logo;
         ContactNumber = shop.ContactNumber;
         EmailAddress = shop.EmailAddress;
         Location = shop.Location;
         isArchived = shop.isArchived;
      }
      public Guid Id { get; set; }
      public String Name { get; set; } = string.Empty;
      public String Logo { get; set; } = string.Empty;
      public String ContactNumber { get; set; } = string.Empty;
      public String EmailAddress { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;
      public bool isArchived { get; set; }
   }
}