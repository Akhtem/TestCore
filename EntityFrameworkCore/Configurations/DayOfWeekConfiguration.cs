using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EntityFrameworkCore.Entities;

namespace EntityFrameworkCore.Configurations
{
    public class DayOfWeekConfiguration : IEntityTypeConfiguration<DayOfWeek>
    {
        public void Configure(EntityTypeBuilder<DayOfWeek> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseSqlServerIdentityColumn();

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .ToTable("DayOfWeek");
        }
    }
}
