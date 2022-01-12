using Dotnet.Api.Domain.Interfaces;
using Dotnet.Api.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.Api.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SqlContext? _context = null;
        private readonly DbSet<T>? table = null;

        public BaseRepository()
        {
            this._context = new SqlContext();
            table = _context.Set<T>();
        }

        public BaseRepository(SqlContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public async Task<IList<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public T GetById(object id)
        {
            //todo findasync
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
