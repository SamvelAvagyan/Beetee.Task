using Beetee.Task.Repository.Models;
using System.Threading.Tasks;

namespace Beetee.Task.Repository.Impl
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DatabaseContext dbContext)
            : base(dbContext)
        { }

        public string GetEmailById(int id)
        {
            return GetById(id).Email;
        }

        public async Task<string> GetEmailByIdAsync(int id)
        {
            Employee employee = await GetByIdAsync(id);
            return employee.Email;
        }
    }
}
