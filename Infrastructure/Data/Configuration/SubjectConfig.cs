using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class SubjectConfig: IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Teacher)
                .WithMany(x => x.Subjects)
                .HasForeignKey(x => x.TeacherId)
                .IsRequired();
        }
    }
}