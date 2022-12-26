using Domain.Base;
using Domain.Exception;

namespace Domain.Entities;

/// <summary>
/// Parts sub group
/// </summary>
public class SubGroup : Entity<int>, IEquatable<SubGroup>
{
    private readonly List<Part> parts = new();
    
    public string Name { get; }

    public int GroupId { get; }
    
    public Group Group { get; }

    public IReadOnlyCollection<Part> Parts => parts.AsReadOnly();

    protected SubGroup()
    {
    }
    
    public SubGroup(string name, Group @group)
    {
        DomainException.ThrowIfNull(name, nameof(name));
        DomainException.ThrowIfNull(@group, nameof(@group));
        
        Name = name;
        Group = @group;
    }

    public void AddPart(Part part)
    {
        DomainException.ThrowIfNull(part, nameof(part));
        if (parts.Contains(part))
        {
            throw new DomainException($"{part.Name}:{part.Code} already exists");
        }
        
        parts.Add(part);
    }
    
    public bool Equals(SubGroup other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && GroupId == other.GroupId;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((SubGroup)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, GroupId);
}
