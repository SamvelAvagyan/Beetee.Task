using Beetee.Task.Repository.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Beetee.Task.Repository.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : AbstractEntity
    {
        private readonly DatabaseContext dbContext;

        public BaseRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Add(T model)
        {
            dbContext.Set<T>().Add(model);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbContext.Set<T>().Remove(GetById(id));
            dbContext.SaveChanges();
        }

        public void Update(T model)
        {
            dbContext.Set<T>().Update(model);
            dbContext.SaveChanges();
        }

        public async ValueTask AddAsync(T model)
        {
            dbContext.Set<T>().Add(model);
            await dbContext.SaveChangesAsync();
        }

        public async ValueTask DeleteAsync(int id)
        {
            dbContext.Set<T>().Remove(await GetByIdAsync(id));
            await dbContext.SaveChangesAsync();
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await System.Threading.Tasks.Task.Run(() =>
            {
                return dbContext.Set<T>();
            });
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async ValueTask UpdateAsync(T model)
        {
            dbContext.Set<T>().Update(model);
            await dbContext.SaveChangesAsync();
        }
    }
}
