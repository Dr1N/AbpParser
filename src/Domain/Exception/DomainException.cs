using System.Data;
using System.Runtime.Serialization;

namespace Domain.Exception;

[Serializable]
public class DomainException : System.Exception
{
    public DomainException()
    {
    }

    protected DomainException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    public DomainException(string message)
        : base(message)
    {
    }

    public DomainException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    public static void ThrowIfNull(object target, string name)
    {
        if (target is null) throw new DataException($"{name} can't be null");
    }
}
