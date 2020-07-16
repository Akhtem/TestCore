using EntityFrameworkCore.Repositories;
using System;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        CourseRepository Courses { get; }
        TimeOfDayRepository TimesOfDay { get; }
        DayOfWeekRepository DaysOfWeek { get; }
        CourseInfoRepository CourseInfos { get; }
        Task<int> CommitAsync();
    }
}
