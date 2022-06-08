using System.Linq;
using System.Threading.Tasks;

namespace Beetee.Task.Repository
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T model);
        void Delete(int id);
        void Update(T model);
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        ValueTask AddAsync(T model);
        ValueTask DeleteAsync(int id);
        ValueTask UpdateAsync(T model);
    }
}
