using Application.Contracts;

namespace Application.Models;

/// <summary>
/// Manufacturer model Dto from models page
/// </summary>
public class ModelDto : IHasUrl
{
    public string Name { get;  set; }
    
    public string Code { get;  set; }
    
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set;}

    public string Url { get; set; }

    public List<ComplectationDto> Complectations { get; } = new();
}
