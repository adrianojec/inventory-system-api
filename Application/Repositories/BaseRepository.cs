using Application.Context;

namespace Application.Repositories
{
   public abstract class BaseRepository
   {
      private readonly IDataContext _context;
      public BaseRepository(IDataContext context)
      {
         _context = context;
      }
   }
}