using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.SqlServer.Configurations;

public class PartConfiguration : IEntityTypeConfiguration<Part>
{
    public void Configure(EntityTypeBuilder<Part> builder)
    {
        builder.ToTable("parts");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(256);
        
        builder.Property(e => e.Code)
            .IsRequired()
            .HasColumnName("code")
            .HasMaxLength(64);
        
        builder.Property(e => e.TreeCode)
            .IsRequired()
            .HasColumnName("tree_code")
            .HasMaxLength(64);
        
        builder.Property(e => e.Count)
            .IsRequired()
            .HasColumnName("count")
            .HasMaxLength(8);
        
        builder.Property(e => e.Info)
            .IsRequired()
            .HasColumnName("info")
            .HasMaxLength(512)
            .HasDefaultValue("");
        
        builder.Property(e => e.StartDate)
            .HasColumnName("start_date");
        
        builder.Property(e => e.EndDate)
            .HasColumnName("end_date");

        builder.Property(e => e.Image)
            .IsRequired()
            .HasColumnName("image")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.SubGroupId)
            .IsRequired()
            .HasColumnName("parts_subgroup_id");
        
        builder.HasOne(e => e.SubGroup)
            .WithMany(e => e.Parts)
            .HasForeignKey(e => e.SubGroupId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.Name);

        builder.HasIndex(e => new { e.Name, e.TreeCode, e.Code });

        builder.HasIndex(e => new { e.Name, e.StartDate, e.EndDate });
    }
}
