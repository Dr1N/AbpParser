using Application.Contracts;
using Domain.Entities;
using Domain.Exception;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarParser;

public class ParsingService : IHostedService
{
    private const string UrlParamName = "Url";
    
    private readonly IManufacturerParser manufacturerParser;
    private readonly IRepository<Manufacturer> repository;
    private readonly ILogger<ParsingService> logger;
    private readonly IHostApplicationLifetime appLifetime;
    private readonly IConfiguration configuration;

    public ParsingService(
        IHostApplicationLifetime appLifetime,
        ILogger<ParsingService> logger,
        IManufacturerParser manufacturerParser,
        IRepository<Manufacturer> repository,
        IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(appLifetime, nameof(appLifetime));
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));
        ArgumentNullException.ThrowIfNull(manufacturerParser, nameof(manufacturerParser));
        ArgumentNullException.ThrowIfNull(repository, nameof(repository));
        ArgumentNullException.ThrowIfNull(configuration, nameof(configuration));
        
        this.appLifetime = appLifetime;
        this.logger = logger;
        this.manufacturerParser = manufacturerParser;
        this.repository = repository;
        this.configuration = configuration;
    }

    public Task StartAsync(CancellationToken token)
    {
        logger.LogInformation("Parser started");
        
        appLifetime.ApplicationStarted.Register(() => ParseAsync(token));
        
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken token)
    {
        logger.LogInformation("Parser stopped");
        
        return Task.CompletedTask;
    }

    private async void ParseAsync(CancellationToken token)
    {
        try
        {
            var url = configuration[UrlParamName];
            logger.LogInformation("Url for parsing: {}", url);

            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                logger.LogError("Invalid url for parsing: {}", url);
                return;
            }

            var manufacturer = await manufacturerParser.ParseAsync(uri, token);
            var currentManufacturer = await repository.GetByPredicateAsync(e => e.Name == manufacturer.Name, token);
            if (currentManufacturer is not null)
            {
                repository.Remove(currentManufacturer);
            }

            await repository.AddAsync(manufacturer, token);
            await repository.SaveChangesAsync(token);
            
            logger.LogInformation("Parsing done: {}", url);
        }
        catch (OperationCanceledException)
        {
            logger.LogWarning("Operation canceled. Stopping parsing...");
        }
        catch (DomainException dex)
        {
            logger.LogError(dex, "Domain exception: {}", dex.Message);
        }
        catch (ApplicationException aex)
        {
            logger.LogError(aex, "Application exception: {}", aex.Message);
        }
        catch (Exception ex)
        {
            logger.LogCritical(ex, "Critical error: {}", ex.Message);
        }
        finally
        {
            appLifetime.StopApplication();
        }
    }
}
