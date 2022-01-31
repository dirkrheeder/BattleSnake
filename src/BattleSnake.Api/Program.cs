
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinitions(typeof(IEndpointDefinition));

builder.Host.ConfigureLogging(logging =>
{
  logging.ClearProviders();
  logging.AddConsole();
});

var app = builder.Build();
app.UseEndpointDefinitions();

app.Logger.LogInformation("The application started");

app.UseHttpLogging();

app.UseHttpsRedirection();

app.Run();
