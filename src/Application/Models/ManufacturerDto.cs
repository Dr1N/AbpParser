namespace Application.Models;

public class ManufacturerDto
{
    public string Name { get; set; }
    
    public List<ModelDto> Models { get; } = new();
}
