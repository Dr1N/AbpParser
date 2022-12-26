using AngleSharp;
using AngleSharp.Dom;
using Application.Constants;
using Application.Models;
using Application.Utils;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Parsers;

/// <inheritdoc />
public class AsModelParser : AsParserBase<ModelDto>
{
    public AsModelParser(ILogger<AsModelParser> logger)
        : base(logger)
    {
    }

    /// <inheritdoc />
    public override async Task<IEnumerable<ModelDto>> ParseAsync(string content, CancellationToken token = default)
    {
        ArgumentNullException.ThrowIfNull(content, nameof(content));

        try
        {
            var result = new List<ModelDto>();
            using var context = BrowsingContext.New(Config);
            using var document = await context.OpenAsync(req => req.Content(content), cancel: token);
            var modelsBlocks = document.QuerySelectorAll(Selectors.ModelListSelector);
            foreach (var block in modelsBlocks)
            {
                try
                {
                    result.AddRange(ParseModels(block));
                }
                catch (Exception ex)
                {
                    Logger.LogWarning("Can't parse model. Error: {}", ex.Message);
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
            throw new ApplicationException("Can't parse model", ex);
        }
    }

    private static IEnumerable<ModelDto> ParseModels(IParentNode block)
    {
        var result = new List<ModelDto>();
        var name = block.QuerySelector(Selectors.ModelNameSelector)?.Text().Trim();
        var codesBlocks = block
            .QuerySelector(Selectors.ModelCodesSelector)
            ?.QuerySelectorAll(Selectors.ModelCodesSelector);

        if (codesBlocks is null) return result;
       
        foreach (var codeBlock in codesBlocks)
        {
            var code = codeBlock.QuerySelector("a")?.Text();
            var url = codeBlock.QuerySelector("a")?.GetAttribute("href");
            var dates = codeBlock.QuerySelector(Selectors.ModelDatesSelector)?.Text();
            var (startDate, endDate) = DateParser.GetDates(dates);
            
            result.Add(new ModelDto()
            {
                Name = name ?? string.Empty,
                Code = code ?? string.Empty,
                Url = url ?? string.Empty,
                StartDate = startDate,
                EndDate = endDate
            });
        }
        
        return result;
    }
}
