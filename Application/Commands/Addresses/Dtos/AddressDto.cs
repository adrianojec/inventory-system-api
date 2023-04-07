using Domain;

namespace Application.Commands.Addresses.Dtos
{
   public class AddressDto
   {
      public AddressDto(Address address)
      {
         Id = address.Id;
         Street = address.Street;
         ZipCode = address.ZipCode;
         City = address.City;
      }
      public Guid Id { get; set; }
      public string Street { get; set; } = string.Empty;
      public int ZipCode { get; set; }
      public string City { get; set; } = string.Empty;
   }
}