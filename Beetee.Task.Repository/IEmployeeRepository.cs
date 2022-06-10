using Beetee.Task.Repository.Models;
using System.Threading.Tasks;

namespace Beetee.Task.Repository
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        string GetEmailById(int id);
        Task<string> GetEmailByIdAsync(int id);
    }
}
