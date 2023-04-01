using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Context
{
   public interface IDataContext
   {
      public DbSet<Shop> Shops { get; set; }
      Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
   }
}