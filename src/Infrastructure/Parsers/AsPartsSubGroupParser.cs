using AngleSharp.Dom;
using Application.Models;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Parsers;

public class AsPartsSubGroupParser : AsGroupParserBase<PartsSubGroupHasUrl>
{
    public AsPartsSubGroupParser(ILogger<AsPartsSubGroupParser> logger)
        : base(logger)
    {
    }
    
    protected override PartsSubGroupHasUrl ParseGroup(IElement element)
    {
        var name = element.Text();
        var url = element.QuerySelector("a")?.GetAttribute("href");

        return new PartsSubGroupHasUrl
        {
            Name = name,
            Url = url,
        };
    }
}
