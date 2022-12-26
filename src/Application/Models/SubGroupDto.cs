using Application.Contracts;

namespace Application.Models;

public class PartsSubGroupHasUrl : IHasUrl
{
    public string Name { get; set; }

    public string Url { get; set; }
    
    public List<PartDto> Parts { get; } = new ();
}
