using Beetee.Task.Repository.Models;

namespace Beetee.Task.Repository.Impl
{
    public class HumanResourceRepository : BaseRepository<HumanResource>, IHumanResourceRepository
    {
        public HumanResourceRepository(DatabaseContext dbContext)
            : base(dbContext)
        { }
    }
}
