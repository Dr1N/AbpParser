using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.SqlServer.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable("parts_groups");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(64);
        
        builder.Property(e => e.ComplectationId)
            .IsRequired()
            .HasColumnName("complectation_id");
        
        builder.HasOne(e => e.Complectation)
            .WithMany(e => e.Groups)
            .HasForeignKey(e => e.ComplectationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.Name);
    }
}
