using Domain.Entities;

namespace Application.Contracts;

/// <summary>
/// Parser all parts by manufacturer and country
/// </summary>
public interface IManufacturerParser
{
    /// <summary>
    /// Parse manufacturer parts
    /// </summary>
    /// <param name="uri">Start page - include manufacturer and country</param>
    /// <param name="token">Cancellation token</param>
    /// <returns>Manufacturer parts data <see cref="Manufacturer"/></returns>
    /// <exception cref="ApplicationException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="OperationCanceledException"></exception>
    Task<Manufacturer> ParseAsync(Uri uri, CancellationToken token = default);
}
