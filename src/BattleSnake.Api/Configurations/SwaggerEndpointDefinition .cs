using Microsoft.OpenApi.Models;

namespace BattleSnake.Api.Configurations;

public class SwaggerEndpointDefinition : IEndpointDefinition
{
  public void DefineEndpoints(WebApplication app)
  {
    if (app.Environment.IsDevelopment())
    {
      app.UseSwagger();
      app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BattleSnake v1"));
    }
  }

  public void DefineServices(IServiceCollection services)
  {
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(c =>
    {
      c.SwaggerDoc("v1", new OpenApiInfo { Title = "BattleSnake", Version = "v1" });
    });
  }
}
