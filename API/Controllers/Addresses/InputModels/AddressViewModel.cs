using Application.Commands.Addresses.Dtos;

namespace API.Controllers.Addresses.InputModels
{
   public class AddressViewModel
   {
      public AddressViewModel(AddressDto address)
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