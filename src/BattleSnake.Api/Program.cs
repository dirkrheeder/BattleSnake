using BattleSnake.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediatR(x => x.AsScoped(), typeof(Program));
var app = builder.Build();

app.MediateGet<GreetingRequest>("/");

app.Run();
