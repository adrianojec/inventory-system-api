using Domain;

namespace Application.Commands.Shops.Dtos
{
   public class CreateShopDto
   {
      public String Name { get; set; } = string.Empty;
      public String Logo { get; set; } = string.Empty;
      public String ContactNumber { get; set; } = string.Empty;
      public String EmailAddress { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;
      public Shop ToShopEntity()
      {
         var shop = new Shop
         {
            Id = Guid.NewGuid(),
            Name = Name,
            Logo = Logo,
            ContactNumber = ContactNumber,
            EmailAddress = EmailAddress,
            Location = Location,
            isArchived = false
         };

         return shop;
      }
   }
}