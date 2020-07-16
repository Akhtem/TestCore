using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EntityFrameworkCore.Entities;

namespace EntityFrameworkCore.Configurations
{
    public class TimeOfDayConfiguration : IEntityTypeConfiguration<TimeOfDay>
    {
        public void Configure(EntityTypeBuilder<TimeOfDay> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseSqlServerIdentityColumn();

            builder
                .Property(m => m.Time)
                .IsRequired();

            builder
                .ToTable("TimeOfDay");
        }
    }
}
