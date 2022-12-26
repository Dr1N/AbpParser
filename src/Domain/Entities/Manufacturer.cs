using System.Data;
using Domain.Base;
using Domain.Exception;

namespace Domain.Entities;

/// <summary>
/// Car manufacturer
/// </summary>
public class Manufacturer : Entity<int>
{
    private readonly List<Model> models = new();
    
    public string Name { get; }

    public IReadOnlyCollection<Model> Models => models.AsReadOnly();

    protected Manufacturer()
    {
    }
    
    public Manufacturer(string name)
    {
        DomainException.ThrowIfNull(name, nameof(name));
        Name = name;
    }

    public void AddModel(Model model)
    {
        DomainException.ThrowIfNull(model, nameof(model));
        if (models.Contains(model))
        {
            throw new DataException($"Model {model.Name} already exists");
        }
        
        models.Add(model);
    }
}
