using System.Data;
using Domain.Base;
using Domain.Exception;

namespace Domain.Entities;

/// <summary>
/// Car model complectation
/// </summary>
public class Complectation : Entity<int>, IEquatable<Complectation>
{
    private readonly List<Group> groups = new();

    public string Name { get; set; }
    
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string AtmMtm { get; set; }

    public string BackDoor { get; set; }
    
    public string Body { get; set; }
    
    public string Body1 { get; set; }
    
    public string Body2 { get; set; }
    
    public string BuildingCondition { get; set; }
    
    public string Cab { get; set; }
    
    public string Category { get; set; }
    
    public string Cooler { get; set; }
    
    public string Deck { get; set; }
    
    public string DeckCab { get; set; }
    
    public string DeckMaterial { get; set; }
    
    public string Destination { get; set; }
    
    public string Destination1 { get; set; }
    
    public string Destination2 { get; set; }
    
    public string DriversPosition { get; set; }
    
    public string EmissionRegulation { get; set; }
    
    public string Engine1 { get; set; }
    
    public string Engine2 { get; set; }
    
    public string FuelInduction { get; set; }
    
    public string GearShiftType { get; set; }
    
    public string Grade { get; set; }
    
    public string GradeMark { get; set; }
    
    public string IncompleteVehicles { get; set; }
    
    public string LoadingCapacity { get; set; }
    
    public string ModelMark { get; set; }
    
    public string NoOfDoors { get; set; }
    
    public string Product { get; set; }
    
    public string RearSuspention { get; set; }
    
    public string RearTire { get;  set; }
    
    public string Rollbar { get; set; }
    
    public string Roof { get; set; }
    
    public string SeatType { get; set; }
    
    public string SeatingCapacity { get; set; }
    
    public string SideWindow { get; set; }
    
    public string TopBackDoor { get; set; }
    
    public string TransmissionModel { get; set; }
    
    public string TruckOrVan { get; set; }
    
    public string VehicleModel { get; set; }
    
    public int ModelId { get; set; }
    
    public Model Model { get; private set; }

    public IReadOnlyCollection<Group> Groups => groups.AsReadOnly();

    protected Complectation()
    {
    }

    public Complectation(Model model)
    {
        DomainException.ThrowIfNull(model, nameof(model));
        
        Model = model;
    }

    public void AddGroup(Group @group)
    {
        if (groups.Contains(@group))
        {
            throw new DataException("Parts group already exists");
        }
        
        groups.Add(@group);
    }
    
    public bool Equals(Complectation other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name
               && Nullable.Equals(StartDate, other.StartDate)
               && Nullable.Equals(EndDate, other.EndDate);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Complectation)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, StartDate, EndDate);
}
