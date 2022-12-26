using AngleSharp;
using Application.Contracts;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Parsers;

/// <summary>
/// Base AngleSharp parser
/// </summary>
/// <typeparam name="T">Parsing object type</typeparam>
public abstract class AsParserBase<T> : IParser<T>
{
    protected readonly ILogger<AsParserBase<T>> Logger;
    protected readonly IConfiguration Config = Configuration.Default;

    protected AsParserBase(ILogger<AsParserBase<T>> logger)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));
        Logger = logger;
    }

    public abstract Task<IEnumerable<T>> ParseAsync(string content, CancellationToken token = default);
}