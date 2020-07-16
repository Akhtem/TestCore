using EntityFrameworkCore.Abstractions;
using EntityFrameworkCore.Contexts;
using EntityFrameworkCore.Repositories;
using System.Threading.Tasks;

namespace EntityFrameworkCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private CourseRepository _courses;
        private CourseInfoRepository _courseInfos;
        private DayOfWeekRepository _daysOfWeek;
        private TimeOfDayRepository _timesOfDay;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            _courses = new CourseRepository(_context);
            _courseInfos = new CourseInfoRepository(_context);
            _daysOfWeek = new DayOfWeekRepository(_context);
            _timesOfDay = new TimeOfDayRepository(_context);
        }

        public CourseRepository Courses { get { return _courses; } }
        public CourseInfoRepository CourseInfos { get { return _courseInfos; } }
        public DayOfWeekRepository DaysOfWeek { get { return _daysOfWeek; } }
        public TimeOfDayRepository TimesOfDay { get { return _timesOfDay; } }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
