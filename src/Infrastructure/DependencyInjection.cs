using Application.Contracts;
using Application.Models;
using Infrastructure.Parsers;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Infrastructure.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    private const string ConnectionName = "CarDbConnection";
    private const string MigrationAssembly = "Infrastructure";
    
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddHttpClient();
        
        // Db Context
        services.AddDbContext<CarDbContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString(ConnectionName) 
                    ?? throw new InvalidOperationException("Invalid database connection string"),
                b => b.MigrationsAssembly(MigrationAssembly));
        }, ServiceLifetime.Singleton);
        
        // Repositories
        services.AddSingleton(
            typeof(IRepository<>),
            typeof(SqlServerRepository<>));
        
        // Parsers
        services.AddSingleton<IPageLoader, HttpPageLoader>();
        services.AddSingleton<IParser<ComplectationDto>, AsComplectationParser>();
        services.AddSingleton<IParser<GroupDto>, AsPartsGroupParser>();
        services.AddSingleton<IParser<PartsSubGroupHasUrl>, AsPartsSubGroupParser>();
        services.AddSingleton<IParser<PartDto>, AsPartParser>();
        services.AddSingleton<IParser<ModelDto>, AsModelParser>();
        
        return services;
    }
}
