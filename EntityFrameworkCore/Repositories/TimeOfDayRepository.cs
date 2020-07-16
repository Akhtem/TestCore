using EntityFrameworkCore.Contexts;
using EntityFrameworkCore.Entities;

namespace EntityFrameworkCore.Repositories
{
    public class TimeOfDayRepository : BaseRepository<TimeOfDay>
    {
        public TimeOfDayRepository(ApplicationDbContext context)
            : base(context)
        { }

        private ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
