namespace BattleSnake.Api.Handlers;

internal class GreetingHandler : IRequestHandler<GreetingRequest, IResult>
{
    public Task<IResult> Handle(GreetingRequest request, CancellationToken cancellationToken)
    {
        var greeting = new GreetingsResponse
        {
            ApiVersion = "1",
            Author = "",
            Color = "#FFFFFF",
            Head = "default",
            Tail = "default"
        };

        return Task.FromResult(Results.Ok(greeting));
    }
}
