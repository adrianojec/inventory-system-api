namespace Application.Repositories
{
   public interface IBaseRepository<T> where T : class
   {
      void Add(T input);
      Task Update(T input);
      Task Delete(Guid id);
      Task<List<T>> GetAll();
      Task<T> GetById(Guid id);
      Task SaveChangesAsync();
   }
}