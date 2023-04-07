using Application.Context;
using Domain;

namespace Application.Repositories.AddressRepositories
{
   public class AddressRepository : IAddressRepository
   {
      private readonly IDataContext _context;
      public AddressRepository(IDataContext context)
      {
         _context = context;
      }
      public async Task Add(Address input)
      {
         _context.Addresses.Add(input);
         await _context.SaveChangesAsync();
      }
      public Task<List<Address>> GetAll()
      {
         throw new NotImplementedException();
      }
      public Task<Address> GetById(Guid id)
      {
         throw new NotImplementedException();
      }
      public Task Update(Address input)
      {
         throw new NotImplementedException();
      }
      public Task Delete(Guid id)
      {
         throw new NotImplementedException();
      }
   }
}