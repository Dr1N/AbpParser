using System.Reflection;
using AngleSharp;
using AngleSharp.Dom;
using Application.Models;
using Application.Utils;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Parsers;

/// <inheritdoc />
public class AsComplectationParser : AsParserBase<ComplectationDto>
{
    private const string NameColumnName = "Комплектация";
    private const string DateColumnName = "Дата";

    public AsComplectationParser(ILogger<AsComplectationParser> logger)
        : base(logger)
    {
    }

    /// <inheritdoc />
    public override async Task<IEnumerable<ComplectationDto>> ParseAsync(string content, CancellationToken token = default)
    {
        ArgumentNullException.ThrowIfNull(content, nameof(content));
        
        try
        {
            using var context = BrowsingContext.New(Config);
            using var document = await context.OpenAsync(req => req.Content(content), cancel: token);
            
            // Table headers - complectation types
            var tableHeaders = document
                .QuerySelector("table")
                ?.QuerySelectorAll("th")
                .Select(e => e.Text())
                .ToList();
            
            // Complectation rows
            var tableRows = document
                .QuerySelector("table")
                ?.QuerySelectorAll("tr")
                .Skip(1)    // Skip header row
                .ToList();

            if (tableHeaders is null || tableRows is null)
            {
                Logger.LogWarning("Can't parse complectation");
                return Enumerable.Empty<ComplectationDto>();
            }

            var complectationsList =  new List<Dictionary<string, IElement>>() ;
            foreach (var row in tableRows)
            {
                try
                {
                    var tableCells = row
                        .QuerySelectorAll("td")
                        .ToList();
                
                    var index = 0;
                    var dictionary = new Dictionary<string, IElement>();
                    foreach (var cell in tableCells)
                    {
                        var rowHeader = tableHeaders[index];
                        dictionary.Add(rowHeader, cell);
                        index++;
                    }
                    complectationsList.Add(dictionary);
                }
                catch (Exception ex)
                {
                   Logger.LogWarning("Can't parse complectation: {}", ex.Message);
                }
            }
            
            return CreateComplectations(complectationsList);
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Can't parse complectation", ex);
        }
    }

    /// <summary>
    /// Create complectations with Reflection
    /// </summary>
    /// <param name="list">List of complectations rows</param>
    /// <returns>List of complectations <see cref="ComplectationDto"/></returns>
    private static IEnumerable<ComplectationDto> CreateComplectations(
        IEnumerable<IReadOnlyDictionary<string, IElement>> list)
    {
        var result = new List<ComplectationDto>();
        var properties = typeof(ComplectationDto)
            .GetProperties(BindingFlags.Instance | BindingFlags.Public);
        
        foreach (var item in list)
        {
            var dto = new ComplectationDto();
            foreach (var (name, value) in item)
            {
                switch (name)
                {
                    // Name
                    case NameColumnName:
                    {
                        var text = value.Text();
                        var url = value.QuerySelector("a")?.GetAttribute("href");
                        dto.Name = text;
                        dto.Url = url;
                        break;
                    }
                    // Dates
                    case DateColumnName:
                    {
                        var (start, end) = DateParser.GetDates(value.Text());
                        dto.StartDate = start.Value;
                        dto.EndDate = end.Value;
                        break;
                    }
                    // Other properties
                    default:
                    {
                        // Filter symbols in column name
                        var filteredColumnName = name
                            .Replace(" ", "")
                            .Replace(",", "")
                            .Replace("(", "")
                            .Replace(")", "")
                            .Replace(".", "")
                            .Replace("'", "");
                        // Find and set property value
                        var property = properties
                            .First(e => string.Equals(e.Name, filteredColumnName,
                                StringComparison.InvariantCultureIgnoreCase));
                        property.SetValue(dto, value.Text());
                        break;
                    }
                }
            }
            
            result.Add(dto);
        }
        
        return result;
    }
}
