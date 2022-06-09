using Beetee.Task.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Beetee.Task.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<HumanResource> HumanResources { get; set; }
    }
}
