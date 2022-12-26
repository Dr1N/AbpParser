using Domain.Base;
using Domain.Exception;

namespace Domain.Entities;

/// <summary>
/// Car model
/// </summary>
public class Model : Entity<int>, IEquatable<Model>
{
    private readonly List<Complectation> complectations = new();

    public string Name { get; }
    
    public string Code { get; }
    
    public DateTime? StartDate { get; }

    public DateTime? EndDate { get; }
    
    public int ManufacturerId { get; }
    
    public Manufacturer Manufacturer { get; }

    public IReadOnlyCollection<Complectation> Complectations => complectations.AsReadOnly();

    protected Model()
    {
    }
    
    public Model(
        string name,
        string code,
        DateTime? startDate,
        DateTime? endDate,
        Manufacturer manufacturer)
    {
        DomainException.ThrowIfNull(name, nameof(name));
        DomainException.ThrowIfNull(code, nameof(code));
        DomainException.ThrowIfNull(manufacturer, nameof(manufacturer));
        
        Name = name;
        Code = code;
        Manufacturer = manufacturer;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void AddComplectation(Complectation complectation)
    {
        DomainException.ThrowIfNull(complectation, nameof(complectation));
        if (complectations.Contains(complectation))
        {
            throw new DomainException($"{nameof(complectation.Name)} already exists");
        }
        
        complectations.Add(complectation);
    }
    
    public bool Equals(Model other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        
        return Name == other.Name && Code == other.Code;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        
        return obj.GetType() == GetType() && Equals((Model)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, Code);
}
