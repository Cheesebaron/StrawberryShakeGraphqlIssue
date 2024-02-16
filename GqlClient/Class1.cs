using Microsoft.Extensions.DependencyInjection;

namespace GqlClient;

public static class ConfigureGqlClient
{
    public static IServiceCollection ConfigureClient(
        this IServiceCollection serviceCollection, Action<HttpClient> configureClient)
    {
        serviceCollection
            .AddGraphQlClient()
            .ConfigureHttpClient(configureClient);

        return serviceCollection;
    }
}