namespace Application.Contracts;

/// <summary>
/// Page content loader
/// </summary>
public interface IPageLoader
{
    /// <summary>
    /// Load page content by uri
    /// </summary>
    /// <param name="uri">Page uri</param>
    /// <param name="token">Cancellation token</param>
    /// <returns>Return page content</returns>
    /// <exception cref="ApplicationException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="OperationCanceledException"></exception>
    Task<string> LoadContentAsync(Uri uri, CancellationToken token = default);
}
