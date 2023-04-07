namespace Application.Repositories
{
   public interface IBaseRepository<T> where T : class
   {
      Task Add(T input);
      Task<List<T>> GetAll();
      Task<T> GetById(Guid id);
      Task Update(T input);
      Task Delete(Guid id);
   }
}