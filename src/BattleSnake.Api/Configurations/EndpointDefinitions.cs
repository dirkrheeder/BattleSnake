namespace BattleSnake.Api.Configurations;

public class EndpointDefinitions : IEndpointDefinition
{
  public void DefineEndpoints(WebApplication app)
  {
    app.MapGet("/", () => new BattleSnakeResponse());
    app.MapPost("/start", (GameRequest gameRequest) => Results.Ok());
    app.MapPost("/move", (GameRequest gameRequest) => new MoveResponse
    {
      Move = MoveDirection.Up,
      Shout = "Here we go!"
    });
    app.MapPost("/end", (GameRequest gameRequest) => Results.Ok());
  }

  public void DefineServices(IServiceCollection services)
  {
    services.AddHttpLogging(logging =>
    {
      // Customize HTTP logging here.
      logging.LoggingFields = HttpLoggingFields.All;
      logging.RequestBodyLogLimit = 4096;
      logging.ResponseBodyLogLimit = 4096;
    });

    services.Configure<JsonOptions>(o => o.SerializerOptions.Converters.Add(new JsonStringEnumConverter()));
    services.Configure<MvcJsonOptions>(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
  }
}
