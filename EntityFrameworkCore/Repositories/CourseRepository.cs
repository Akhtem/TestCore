using EntityFrameworkCore.Contexts;
using EntityFrameworkCore.Entities;

namespace EntityFrameworkCore.Repositories
{
    public class CourseRepository : BaseRepository<Course>
    {
        public CourseRepository(ApplicationDbContext context)
            : base(context)
        { }

        private ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
