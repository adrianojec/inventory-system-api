namespace Domain
{
   public class Address
   {
      public Guid Id { get; set; }
      public string Street { get; set; } = string.Empty;
      public int ZipCode { get; set; }
      public string City { get; set; } = string.Empty;
   }
}