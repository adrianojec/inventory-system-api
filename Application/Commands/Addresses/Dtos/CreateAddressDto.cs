using Domain;

namespace Application.Commands.Addresses.Dtos
{
   public class CreateAddressDto
   {
      public string Street { get; set; } = string.Empty;
      public int ZipCode { get; set; }
      public string City { get; set; } = string.Empty;

      public Address ToAddressEntity()
      {
         var address = new Address
         {
            Street = Street,
            ZipCode = ZipCode,
            City = City,
         };

         return address;
      }
   }
}