using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.SqlServer.Configurations;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("models");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(64);
        
        builder.Property(e => e.Code)
            .IsRequired()
            .HasColumnName("code")
            .HasMaxLength(32);
        
        builder.Property(e => e.StartDate)
            .HasColumnName("start_date");
        
        builder.Property(e => e.EndDate)
            .HasColumnName("end_date");

        builder.Property(e => e.ManufacturerId)
            .IsRequired()
            .HasColumnName("manufacturer_id");
        
        builder.HasOne(e => e.Manufacturer)
            .WithMany(e => e.Models)
            .HasForeignKey(e => e.ManufacturerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.Name);

        builder.HasIndex(e => new { e.Name, e.Code });

        builder.HasIndex(e => new { e.Name, e.Code, e.StartDate, e.EndDate });
    }
}
