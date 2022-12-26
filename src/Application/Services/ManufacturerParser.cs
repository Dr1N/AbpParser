using Application.Contracts;
using Application.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.Logging;

namespace Application.Services;

public class ManufacturerParser : IManufacturerParser
{
    private readonly IReadOnlyList<string> supportedMarks = new List<string>()
    {
        "toyota"
    };

    private readonly IPageLoader pageLoader;
    private readonly IParser<ModelDto> modelsParser;
    private readonly IParser<ComplectationDto> complectationParser;
    private readonly IParser<GroupDto> groupParser;
    private readonly IParser<PartsSubGroupHasUrl> subGroupParser;
    private readonly IParser<PartDto> partParser;
    private readonly ILogger<ManufacturerParser> logger;
    private readonly IMapper mapper;

    public ManufacturerParser(
        IPageLoader pageLoader,
        ILogger<ManufacturerParser> logger,
        IParser<ModelDto> modelsParser,
        IParser<ComplectationDto> complectationParser,
        IParser<GroupDto> groupParser,
        IParser<PartsSubGroupHasUrl> subGroupParser,
        IParser<PartDto> partParser,
        IMapper mapper)
    {
        ArgumentNullException.ThrowIfNull(pageLoader, nameof(pageLoader));
        ArgumentNullException.ThrowIfNull(modelsParser, nameof(modelsParser));
        ArgumentNullException.ThrowIfNull(complectationParser, nameof(complectationParser));
        ArgumentNullException.ThrowIfNull(groupParser, nameof(groupParser));
        ArgumentNullException.ThrowIfNull(subGroupParser, nameof(subGroupParser));
        ArgumentNullException.ThrowIfNull(partParser, nameof(partParser));
        ArgumentNullException.ThrowIfNull(mapper, nameof(mapper));
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));
        
        this.pageLoader = pageLoader;
        this.logger = logger;
        this.modelsParser = modelsParser;
        this.complectationParser = complectationParser;
        this.groupParser = groupParser;
        this.subGroupParser = subGroupParser;
        this.partParser = partParser;
        this.mapper = mapper;
    }

    public async Task<Manufacturer> ParseAsync(Uri uri, CancellationToken token = default)
    {
        ValidateManufacturer(uri);
        
        try
        {
            var manufacturerDto = await ParseManufacturerAsync(uri, token);
            
            return CreateManufacturer(manufacturerDto);
        }
        catch (OperationCanceledException)
        {
            logger.LogDebug("Parsing manufacturer canceled");
            throw;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Can't parse manufacturer", ex);
        }
    }

    private void ValidateManufacturer(Uri uri)
    {
        ArgumentNullException.ThrowIfNull(uri, nameof(uri));
        
        var selectedMark = uri.AbsolutePath.Trim('/');
        var isSupported = supportedMarks.Any(mark
            => string.Equals(selectedMark, mark, StringComparison.InvariantCultureIgnoreCase));

        if (isSupported) return;
        
        // Not supported manufacturer
        var marks = string.Join(", ", supportedMarks);
        throw new ApplicationException(
            $"Selected manufactured not supported. Parser support: {marks}" );
    }

    /// <summary>
    /// Parsed child objects for model 
    /// </summary>
    /// <param name="uri">Manufacturer url</param>
    /// <param name="model">Model for parsing <see cref="IHasUrl"/></param>
    /// <param name="parser">Parser for parsing</param>
    /// <param name="token">Cancellation token</param>
    /// <typeparam name="TOut">Type out object</typeparam>
    /// <typeparam name="TIn">Parsed model type</typeparam>
    /// <returns>Array of child for model</returns>
    private async Task<TOut[]> ParseObjectAsync<TOut, TIn>(
        Uri uri,
        TIn model,
        IParser<TOut> parser,
        CancellationToken token)
        where TIn : IHasUrl
    {
        var modelUrl = $"{uri.GetLeftPart(UriPartial.Authority)}{model.Url}";
        if (!Uri.TryCreate(modelUrl, UriKind.Absolute, out var modelUri))
        {
            logger.LogWarning("Invalid model url: {}", model.Url);
            return Array.Empty<TOut>();
        }
                
        var modelPageContent = await pageLoader.LoadContentAsync(modelUri, token);
        var results = (await parser.ParseAsync(modelPageContent, token))
            .ToArray();

        return results;
    }

    /// <summary>
    /// Parse Manufacturer data
    /// </summary>
    /// <param name="uri">Start url</param>
    /// <param name="token">Cancellation token</param>
    /// <returns>Manufacturer Dto <see cref="Manufacturer"/></returns>
    private async Task<ManufacturerDto> ParseManufacturerAsync(Uri uri, CancellationToken token)
    {
        var manufacturerDto = new ManufacturerDto
        {
            Name = uri.AbsolutePath.Trim('/').ToUpper()
        };
            
        // Manufacturer page - start point
        var modelsPage = await pageLoader.LoadContentAsync(uri, token);
            
        // Manufacturer models
        var models = (await modelsParser.ParseAsync(modelsPage, token))
            .Skip(1)
            .Take(1) // TODO: test
            .ToList();
        manufacturerDto.Models.AddRange(models);
            
        foreach (var model in models)
        {
            // Complectations
            var complectations = await ParseObjectAsync(uri, model, complectationParser, token);
            model.Complectations.AddRange(complectations);
                
            // Complectation parts group
            foreach (var complectation in complectations)
            {
                var partsGroups = await ParseObjectAsync(uri, complectation, groupParser, token);
                complectation.Groups.AddRange(partsGroups);
                    
                // Group sub group
                foreach (var partsGroup in partsGroups)
                {
                    var partsSubGroups = await ParseObjectAsync(uri, partsGroup, subGroupParser, token);
                    partsGroup.SubGroups.AddRange(partsSubGroups);
                        
                    // Parts
                    foreach (var subGroup in partsSubGroups)
                    {
                        var parts = await ParseObjectAsync(uri, subGroup, partParser, token);
                        subGroup.Parts.AddRange(parts);
                    }
                }
            }
        }

        return manufacturerDto;
    }
    
    /// <summary>
    /// Create Manufacturer entity from dtp
    /// </summary>
    /// <param name="dto">Manufacturer dto <see cref="ManufacturerDto"/></param>
    /// <returns>Manufacturer dto <see cref="Manufacturer"/></returns>
    private Manufacturer CreateManufacturer(ManufacturerDto dto)
    {
        var manufacturer = new Manufacturer(dto.Name);
        foreach (var modelDto in dto.Models)
        {
            var model = new Model(
                modelDto.Name,
                modelDto.Code,
                modelDto.StartDate,
                modelDto.EndDate,
                manufacturer);
            manufacturer.AddModel(model);
            foreach (var complectationDto in modelDto.Complectations)
            {
                var complectation = new Complectation(model);
                complectation = mapper.Map(complectationDto, complectation);
                model.AddComplectation(complectation);
                foreach (var groupDto in complectationDto.Groups)
                {
                    var group = new Group(groupDto.Name, complectation);
                    complectation.AddGroup(group);
                    foreach (var subGroupDto in groupDto.SubGroups)
                    {
                        var subGroup = new SubGroup(subGroupDto.Name, group);
                        group.AddSubGroup(subGroup);
                        foreach (var partDto in subGroupDto.Parts)
                        {
                            var part = new Part(
                                partDto.Name,
                                partDto.Code,
                                partDto.TreeCode,
                                partDto.Count,
                                partDto.Info,
                                partDto.StartDate,
                                partDto.EndDate,
                                partDto.Image,
                                subGroup);
                            subGroup.AddPart(part);
                        }
                    }
                }
            }
        }

        return manufacturer;
    }
}
