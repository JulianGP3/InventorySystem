
namespace Inventory.Api.Handling;

public static class DependencyInjectionHandler
{
    public static void ConfigureService(IServiceCollection services)
    {
        services.AddHttpClient();
    }
}
