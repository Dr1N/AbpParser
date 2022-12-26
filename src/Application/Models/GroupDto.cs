using Application.Contracts;

namespace Application.Models;

public class GroupDto : IHasUrl
{
    public string Name { get; set; }

    public string Url { get; set; }

    public List<PartsSubGroupHasUrl> SubGroups { get; } = new();
}
