namespace Web.Api.Endpoints.Ping;

internal sealed class Ping : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/ping", () => "Pong");
    }
}
