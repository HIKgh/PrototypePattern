using Application.Implementations;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IPrototypePatternService, PrototypePatternService>();

        return services.BuildServiceProvider();
    }
}