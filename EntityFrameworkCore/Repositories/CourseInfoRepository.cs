using EntityFrameworkCore.Contexts;
using EntityFrameworkCore.Entities;

namespace EntityFrameworkCore.Repositories
{
    public class CourseInfoRepository : BaseRepository<CourseInfo>
    {
        public CourseInfoRepository(ApplicationDbContext context)
            : base(context)
        { }

        private ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}