using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class GroupConfig: IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.Members)
                .WithMany(x => x.Groups);

            builder
                .HasOne(x => x.Owner)
                .WithMany(x => x.OwnedGroups)
                .HasForeignKey(x => x.OwnerId)
                .IsRequired();
        }
    }
}