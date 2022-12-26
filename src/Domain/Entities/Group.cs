using Domain.Base;
using Domain.Exception;

namespace Domain.Entities;

/// <summary>
/// Parts Group
/// </summary>
public class Group : Entity<int>, IEquatable<Group>
{
    private readonly List<SubGroup> subGroups = new();

    public string Name { get; }
    
    public int ComplectationId { get; }
    
    public Complectation Complectation { get; }

    public IReadOnlyCollection<SubGroup> SubGroups => subGroups.AsReadOnly();

    protected Group()
    {
    }
    
    public Group(string name, Complectation complectation)
    {
        DomainException.ThrowIfNull(name, nameof(name));
        DomainException.ThrowIfNull(complectation, nameof(complectation));
        
        Name = name;
        Complectation = complectation;
    }

    public void AddSubGroup(SubGroup subgroup)
    {
        DomainException.ThrowIfNull(subgroup, nameof(subgroup));
        if (subGroups.Contains(subgroup))
        {
            throw new DomainException($"{subgroup.Name} already exists");
        }
        
        subGroups.Add(subgroup);
    }

    public bool Equals(Group other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && ComplectationId == other.ComplectationId;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Group)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, ComplectationId);
}
