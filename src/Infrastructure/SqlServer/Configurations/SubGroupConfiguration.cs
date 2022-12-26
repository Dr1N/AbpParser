using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.SqlServer.Configurations;

public class SubgroupConfiguration : IEntityTypeConfiguration<SubGroup>
{
    public void Configure(EntityTypeBuilder<SubGroup> builder)
    {
        builder.ToTable("parts_sub_groups");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(256);
        
        builder.Property(e => e.GroupId)
            .IsRequired()
            .HasColumnName("parts_group_id");
        
        builder.HasOne(e => e.Group)
            .WithMany(e => e.SubGroups)
            .HasForeignKey(e => e.GroupId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.Name);
    }
}
