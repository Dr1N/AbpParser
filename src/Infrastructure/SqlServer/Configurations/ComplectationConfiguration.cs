using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.SqlServer.Configurations;

public class ComplectationConfiguration : IEntityTypeConfiguration<Complectation>
{
    public void Configure(EntityTypeBuilder<Complectation> builder)
    {
        builder.ToTable("complectations");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(128);
        
        builder.Property(e => e.StartDate)
            .HasColumnName("start_date");
        
        builder.Property(e => e.EndDate)
            .HasColumnName("end_date");
        
        builder.Property(e => e.AtmMtm)
            .IsRequired()
            .HasColumnName("atm_mtm")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.BackDoor)
            .IsRequired()
            .HasColumnName("back_door")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Body)
            .IsRequired()
            .HasColumnName("body")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Body1)
            .IsRequired()
            .HasColumnName("body_1")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Body2)
            .IsRequired()
            .HasColumnName("body_2")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.BuildingCondition)
            .IsRequired()
            .HasColumnName("building_condition")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Cab)
            .IsRequired()
            .HasColumnName("cab")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Category)
            .IsRequired()
            .HasColumnName("category")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Cooler)
            .IsRequired()
            .HasColumnName("cooler")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Deck)
            .IsRequired()
            .HasColumnName("deck")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.DeckCab)
            .IsRequired()
            .HasColumnName("deck_cab")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.DeckMaterial)
            .IsRequired()
            .HasColumnName("deck_material")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Destination)
            .IsRequired()
            .HasColumnName("destination")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Destination1)
            .IsRequired()
            .HasColumnName("destination_1")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Destination2)
            .IsRequired()
            .HasColumnName("destination_2")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.DriversPosition)
            .IsRequired()
            .HasColumnName("drivers_position")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.EmissionRegulation)
            .IsRequired()
            .HasColumnName("emission_regulation")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Engine1)
            .IsRequired()
            .HasColumnName("engine_1")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Engine2)
            .IsRequired()
            .HasColumnName("engine_2")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.FuelInduction)
            .IsRequired()
            .HasColumnName("fuel_induction")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.GearShiftType)
            .IsRequired()
            .HasColumnName("gear_shift_type")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Grade)
            .IsRequired()
            .HasColumnName("grade")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.GradeMark)
            .IsRequired()
            .HasColumnName("grade_mark")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.IncompleteVehicles)
            .IsRequired()
            .HasColumnName("incomplete_vehicles")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.LoadingCapacity)
            .IsRequired()
            .HasColumnName("loading_capacity")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.ModelMark)
            .IsRequired()
            .HasColumnName("model_mark")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.NoOfDoors)
            .IsRequired()
            .HasColumnName("no_of_doors")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Product)
            .IsRequired()
            .HasColumnName("product")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.RearSuspention)
            .IsRequired()
            .HasColumnName("rear_suspention")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.RearTire)
            .IsRequired()
            .HasColumnName("rear_tire")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Rollbar)
            .IsRequired()
            .HasColumnName("rollbar")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.Roof)
            .IsRequired()
            .HasColumnName("roof")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        
        builder.Property(e => e.SeatType)
            .IsRequired()
            .HasColumnName("seat_type")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.SeatingCapacity)
            .IsRequired()
            .HasColumnName("seating_capacity")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.SideWindow)
            .IsRequired()
            .HasColumnName("side_window")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.TopBackDoor)
            .IsRequired()
            .HasColumnName("top_back_door")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.TransmissionModel)
            .IsRequired()
            .HasColumnName("transmission_model")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.TruckOrVan)
            .IsRequired()
            .HasColumnName("truck_or_van")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.VehicleModel)
            .IsRequired()
            .HasColumnName("vehicle_model")
            .HasMaxLength(128)
            .HasDefaultValue("");
        
        builder.Property(e => e.ModelId)
            .IsRequired()
            .HasColumnName("model_id");
        
        builder.HasOne(e => e.Model)
            .WithMany(e => e.Complectations)
            .HasForeignKey(e => e.ModelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.Name);

        builder.HasIndex(e => new { e.Name, e.StartDate, e.EndDate });
    }
}
