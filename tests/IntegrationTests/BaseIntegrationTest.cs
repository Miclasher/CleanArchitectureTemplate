using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace IntegrationTests;

[Collection(nameof(IntegrationTestCollection))]
public abstract class BaseIntegrationTest
{
    protected BaseIntegrationTest(IntegrationTestWebAppFactory factory)
    {
        HttpClient = factory.CreateClient();
    }

    protected HttpClient HttpClient { get; }
}
