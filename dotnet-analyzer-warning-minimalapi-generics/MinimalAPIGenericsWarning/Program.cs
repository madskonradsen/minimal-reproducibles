var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

static void UseEndpoint<TEndpointInput>(WebApplication app) where TEndpointInput : class
{
    app.MapPost("/test", (TEndpointInput data) => Results.Ok(data));
}

UseEndpoint<DummyEndpointInput>(app);

app.Run();

public class DummyEndpointInput
{
}