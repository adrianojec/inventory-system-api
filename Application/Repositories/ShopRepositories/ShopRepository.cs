using Application.Context;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories.ShopRepositories
{
   public class ShopRepository : IShopRepository
   {
      private readonly IDataContext _context;
      public ShopRepository(IDataContext context)
      {
         _context = context;
      }
      public void Add(Shop input)
      {
         _context.Shops.Add(input);
      }

      public Task Delete(Guid id)
      {
         throw new NotImplementedException();
      }

      public async Task<List<Shop>> GetAll()
      {
         var shops = await _context.Shops.ToListAsync();
         return shops;
      }

      public Task<Shop> GetById(Guid id)
      {
         throw new NotImplementedException();
      }

      public async Task SaveChangesAsync()
      {
         await _context.SaveChangesAsync();
      }

      public Task Update(Shop input)
      {
         throw new NotImplementedException();
      }
   }
}