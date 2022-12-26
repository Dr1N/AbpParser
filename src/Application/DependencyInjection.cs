using Application.Contracts;
using Application.Profiles;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddSingleton<IManufacturerParser, ManufacturerParser>();
        services.AddAutoMapper(typeof(ComplectationProfile));
        
        return services;
    }
}
