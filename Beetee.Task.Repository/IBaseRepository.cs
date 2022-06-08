using System.Linq;
using System.Threading.Tasks;

namespace Beetee.Task.Repository
{
    public interface IBaseRepository<T>
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        ValueTask AddAsync(T model);
        ValueTask DeleteAsync(int id);
        ValueTask UpdateAsync(T model);
    }
}
