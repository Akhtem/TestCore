using EntityFrameworkCore.Configurations;
using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<DayOfWeek> DaysOfWeek { get; set; }
        public DbSet<TimeOfDay> TimesOfDay { get; set; }
        public DbSet<CourseInfo> CourseInfos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new CourseConfiguration());
            builder
                .ApplyConfiguration(new DayOfWeekConfiguration());
            builder
                .ApplyConfiguration(new TimeOfDayConfiguration());
        }
    }
}
