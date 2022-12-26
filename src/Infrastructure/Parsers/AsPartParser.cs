using AngleSharp;
using AngleSharp.Dom;
using Application.Constants;
using Application.Models;
using Application.Utils;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Parsers;

public class AsPartParser : AsParserBase<PartDto>
{
    public AsPartParser(ILogger<AsPartParser> logger)
        : base(logger)
    {
    }

    public override async Task<IEnumerable<PartDto>> ParseAsync(string content, CancellationToken token = default)
    {
        try
        {
            using var context = BrowsingContext.New(Config);
            using var document = await context.OpenAsync(req => req.Content(content), cancel: token);
            var partsTable = document.QuerySelector("table");

            if (partsTable is null)
            {
                Logger.LogWarning("Can't find parts table");
                return Enumerable.Empty<PartDto>();
            }
            
            var rows = partsTable.QuerySelectorAll("tr")
                .Skip(1) // Skip header
                .ToList();

            return rows.Count <= 2 ? Enumerable.Empty<PartDto>() : GetParts(rows);
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Can't parse part", ex);
        }
    }

    /// <summary>
    /// Create Parts dto from part rows
    /// </summary>
    /// <param name="rows">Part rows</param>
    /// <returns>Collection of dto</returns>
    private IEnumerable<PartDto> GetParts(IReadOnlyList<IElement> rows)
    {
        var result = new List<PartDto>();
        var partRows = GetPartsRows(rows, GetHeaderIndexes(rows));

        foreach (var part in partRows)
        {
            try
            {
                // Broken part 
                if (part.Count < 2) continue;
            
                // Common data for parts
                var treeCode = part[0]?.GetAttribute(Selectors.PartNumberAttribute);
                var name = part[0].Text().Replace(treeCode, string.Empty).Trim();
            
                // Create dto for each code (row)
                for (var i = 1; i < part.Count; i++)
                {
                    var (startDate, endDate) = DateParser.GetDates(part[i].QuerySelector(Selectors.PartDatesSelector)?.Text());
                    var currentDto = new PartDto
                    {
                        Name = name,
                        TreeCode = treeCode,
                        Code = part[i].QuerySelector(Selectors.PartCodeSelector)?.Text(),
                        Count = part[i].QuerySelector(Selectors.PartCountSelector)?.Text(),
                        Info = part[i].QuerySelector(Selectors.PartInfoSelector)?.Text(),
                        StartDate = startDate.Value,
                        EndDate = endDate.Value,
                        Image = Guid.NewGuid().ToString(),
                    };
               
                    result.Add(currentDto);
                }
            }
            catch (Exception ex)
            {
                Logger.LogWarning("Can't parse part rows: {}", ex.Message);
            }
        }
        
        return result;
    }

    /// <summary>
    /// Get Part headers indexes
    /// </summary>
    /// <param name="rows">Parts rows</param>
    /// <returns>List of headers indexes</returns>
    private static List<int> GetHeaderIndexes(IReadOnlyList<IElement> rows)
    {
        var headerIndexes = new List<int>();
        for (var i = 0; i < rows.Count; i++)
        {
            if (rows[i].QuerySelector("th") is null) continue;
            
            headerIndexes.Add(i);
        }

        return headerIndexes;
    }

    /// <summary>
    /// Brain fuck method. Separate rows to Parts
    /// </summary>
    /// <param name="rows">Table rows</param>
    /// <param name="headerIndexes">Part headers indexes</param>
    /// <returns>Collection of collections Part rows with header</returns>
    private static IEnumerable<List<IElement>> GetPartsRows(
        IReadOnlyCollection<IElement> rows,
        IReadOnlyList<int> headerIndexes)
    {
        // One part in table
        if (rows.Count == 2)
        {
            return new List<List<IElement>> { rows.ToList() };
        }
        
        // Many parts
        var result = new List<List<IElement>>();
        for (var i = 0; i < headerIndexes.Count; i++)
        {
            var isLastHeader = i == headerIndexes.Count - 1;
            var partChunk = isLastHeader 
                ? rows.Skip(headerIndexes[i]).Take(rows.Count - headerIndexes[i]).ToList()
                : rows.Skip(headerIndexes[i]).Take(headerIndexes[i + 1] - headerIndexes[i]).ToList();
            result.Add(partChunk);
        }
        
        return result;
    }
}
