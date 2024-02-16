// See https://aka.ms/new-console-template for more information

using GqlClient;
using Microsoft.Extensions.DependencyInjection;
using TrackMan.Api.Range.GqlV2;

var serviceCollection = new ServiceCollection();
serviceCollection
    .ConfigureClient(client =>
    {
        client.BaseAddress = new Uri("https://dr-cloud-api-dev.trackmangolfdev.com/graphql/");
    });

var serviceProvider = serviceCollection.BuildServiceProvider();

var client = serviceProvider.GetRequiredService<GraphQlClient>();
var result = await client.ReportVirtualRange.ExecuteAsync("1234");
// result.Data.Node.