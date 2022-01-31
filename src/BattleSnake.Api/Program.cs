
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinitions(typeof(IEndpointDefinition));

builder.Logging.ClearProviders();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddEnvironmentVariables()
    .Build();

var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(configuration)
  .Enrich.FromLogContext()
  .CreateLogger();

builder.Logging.AddSerilog(logger);

//builder.Host.UseSerilog();

var app = builder.Build();
app.UseEndpointDefinitions();

app.Logger.LogInformation("The application started");

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.Run();
