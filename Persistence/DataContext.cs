using Application.Context;
using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
   public class DataContext : IdentityDbContext<User>, IDataContext
   {
      public DataContext(DbContextOptions options) : base(options)
      {

      }

      public DbSet<Address> Addresses { get; set; } = default!;
   }
}