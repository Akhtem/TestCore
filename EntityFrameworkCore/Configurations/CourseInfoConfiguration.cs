using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Configurations
{
    public class CourseInfoConfiguration : IEntityTypeConfiguration<CourseInfo>
    {
        public void Configure(EntityTypeBuilder<CourseInfo> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.CourseId)
                .IsRequired();

            builder
                .Property(m => m.TimeOfDayId)
                .IsRequired();

            builder
                .Property(m => m.DayOfWeekId)
                .IsRequired();

            builder
                .ToTable("CourseInfo");
        }
    }
}