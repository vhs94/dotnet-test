namespace Dotnet.Api.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IList<T>> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
