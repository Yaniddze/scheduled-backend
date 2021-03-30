using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class GroupSubjectConfig: IEntityTypeConfiguration<GroupSubject>
    {
        public void Configure(EntityTypeBuilder<GroupSubject> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Group)
                .WithMany(x => x.GroupSubjects)
                .HasForeignKey(x => x.GroupId)
                .IsRequired();

            builder
                .HasOne(x => x.Subject)
                .WithMany(x => x.GroupSubjects)
                .HasForeignKey(x => x.SubjectId)
                .IsRequired();
        }
    }
}