using AngleSharp;
using AngleSharp.Dom;
using Application.Constants;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Parsers;

public abstract class AsGroupParserBase<T> : AsParserBase<T>
{
    protected AsGroupParserBase(ILogger<AsGroupParserBase<T>> logger)
        : base(logger)
    {
    }
    
    /// <inheritdoc />
    public override async Task<IEnumerable<T>> ParseAsync(string content, CancellationToken token)
    {
        ArgumentNullException.ThrowIfNull(content, nameof(content));

        try
        {
            var result = new List<T>();
            using var context = BrowsingContext.New(Config);
            using var document = await context.OpenAsync(req => req.Content(content), cancel: token);
            var groups = document.QuerySelectorAll(Selectors.PartsGroupSelector);
            foreach (var group in groups)
            {
                try
                {
                    var dto = ParseGroup(group);
                    result.Add(dto);
                }
                catch (Exception ex)
                {
                    Logger.LogWarning("Can't parse parts group: {}", ex.Message);
                }
            }
            
            return result;
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Can't parse parts group", ex);
        }
    }

    protected abstract T ParseGroup(IElement element);
}
