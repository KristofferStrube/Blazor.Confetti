using Microsoft.Extensions.DependencyInjection;

namespace KristofferStrube.Blazor.Confetti;

public static class IServiceExtensions
{
    public static IServiceCollection AddConfettiService(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddScoped<ConfettiService>();
    }
}
