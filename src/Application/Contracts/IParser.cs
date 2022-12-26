namespace Application.Contracts;

/// <summary>
/// Parser objects from html content
/// </summary>
///
public interface IParser<T>
{
    /// <summary>
    /// Parse objects from html page content
    /// </summary>
    /// <param name="content">Page content</param>
    /// <param name="token">Cancellation token</
    /// param>
    /// <returns>Collection of objects</returns>
    Task<IEnumerable<T>> ParseAsync(string content, CancellationToken token = default);
}
