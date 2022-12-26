using Application.Contracts;

namespace Infrastructure.Services;

/// <inheritdoc />
public class HttpPageLoader : IPageLoader
{
    private readonly IHttpClientFactory httpClientFactory;

    public HttpPageLoader(IHttpClientFactory httpClientFactory)
    {
        ArgumentNullException.ThrowIfNull(httpClientFactory, nameof(httpClientFactory));
        this.httpClientFactory = httpClientFactory;
    }
    
    /// <inheritdoc />
    public async Task<string> LoadContentAsync(Uri uri, CancellationToken token = default)
    {
        ArgumentNullException.ThrowIfNull(uri, nameof(uri));

        try
        {
            using var httpClient = httpClientFactory.CreateClient();
            using var response = await httpClient.GetAsync(uri, token);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(
                    $"Can't load page: {uri.AbsoluteUri}. Status code: {response.StatusCode}");
            }

            return await response.Content.ReadAsStringAsync(token);
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new ApplicationException($"Can't load page: {uri.AbsoluteUri}", e);
        }
    }
}
