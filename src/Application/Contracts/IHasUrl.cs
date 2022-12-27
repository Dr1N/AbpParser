namespace Application.Contracts;

/// <summary>
/// Base interface for Dto with Url to chile page
/// </summary>
public interface IHasUrl
{
    public string Url { get; set; }
}