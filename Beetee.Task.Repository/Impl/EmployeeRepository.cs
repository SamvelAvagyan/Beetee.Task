using Beetee.Task.Repository.Models;

namespace Beetee.Task.Repository.Impl
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DatabaseContext dbContext)
            : base(dbContext)
        { }
    }
}
