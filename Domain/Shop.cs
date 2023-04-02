namespace Domain
{
   public class Shop
   {
      public Guid Id { get; set; }
      public String Name { get; set; } = string.Empty;
      public String Logo { get; set; } = string.Empty;
      public String ContactNumber { get; set; } = string.Empty;
      public String EmailAddress { get; set; } = string.Empty;
      public String Location { get; set; } = string.Empty;
      public bool isArchived { get; set; }
   }
}