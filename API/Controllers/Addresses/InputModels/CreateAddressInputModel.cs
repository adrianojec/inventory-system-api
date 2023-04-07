using Application.Commands.Addresses.Dtos;

namespace API.Controllers.Addresses.InputModels
{
   public class CreateAddressInputModel
   {
      public string Street { get; set; } = string.Empty;
      public int ZipCode { get; set; }
      public string City { get; set; } = string.Empty;

      public CreateAddressDto ToCreateAddressDto()
      {
         var address = new CreateAddressDto
         {
            Street = Street,
            ZipCode = ZipCode,
            City = City,
         };

         return address;
      }
   }
}