using Application.Commands.Shops.Dtos;

namespace API.Controllers.Shops.ViewModels
{
   public class ShopViewModel
   {
      public ShopViewModel(ShopDto input)
      {
         Id = input.Id;
         Name = input.Name;
         Image = input.Image;
         Location = input.Location;
      }
      public Guid Id { get; set; }
      public String Name { get; set; } = string.Empty;
      public String Image { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;
   }
}