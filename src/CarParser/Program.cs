using Application;
using CarParser;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var app = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddHostedService<ParsingService>();
        services.AddInfrastructure(hostContext.Configuration);
        services.AddApplication();
    })
    .Build();

app.Run();
    