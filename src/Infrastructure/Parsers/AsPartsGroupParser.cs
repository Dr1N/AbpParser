using AngleSharp.Dom;
using Application.Models;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Parsers;

public class AsPartsGroupParser : AsGroupParserBase<GroupDto>
{
    public AsPartsGroupParser(ILogger<AsPartsGroupParser> logger)
        : base(logger)
    {
    }
    
    protected override GroupDto ParseGroup(IElement element)
    {
        var name = element.Text();
        var url = element.QuerySelector("a")?.GetAttribute("href");

        return new GroupDto
        {
            Name = name,
            Url = url,
        };
    }
}
