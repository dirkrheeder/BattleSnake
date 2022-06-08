namespace BattleSnake.Api.Models.Response;

public class BattleSnakeResponse
{
    public string ApiVersion { get; init; } = "1";
    public string Author { get; init; } = "MyUserName";
    public string Color { get; init; } = "#888888";
    public string Head { get; init; } = "default";
    public string Tail { get; init; } = "default";
    public string Version { get; init; } = "0.0.1";
}
