using Domain.Base;
using Domain.Exception;

namespace Domain.Entities;

public class Part : Entity<int>, IEquatable<Part>
{
    public string Name { get; }

    public string Code { get; }
    
    public string TreeCode { get; }
    
    public string Count { get; }
    
    public string Info { get; }
    
    public DateTime? StartDate { get; }

    public DateTime? EndDate { get; }
    
    public string Image { get; }

    public int SubGroupId { get; }
    
    public SubGroup SubGroup { get; }

    protected Part()
    {
    }
    
    public Part(string name,
        string code,
        string treeCode,
        string count,
        string info,
        DateTime startDate,
        DateTime endDate,
        string image,
        SubGroup subGroup)
    {
        DomainException.ThrowIfNull(name, nameof(name));
        DomainException.ThrowIfNull(treeCode, nameof(treeCode));
        DomainException.ThrowIfNull(info, nameof(info));
        DomainException.ThrowIfNull(image, nameof(image));
        DomainException.ThrowIfNull(subGroup, nameof(subGroup));
        
        Name = name;
        Code = code;
        TreeCode = treeCode;
        Count = count;
        Info = info;
        StartDate = startDate;
        EndDate = endDate;
        Image = image;
        SubGroup = subGroup;
    }

    public bool Equals(Part other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name
               && Code == other.Code
               && TreeCode == other.TreeCode
               && StartDate == other.StartDate
               && EndDate == other.EndDate
               && Info == other.Info;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Part)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, Code, TreeCode, StartDate, EndDate, Info);
}
