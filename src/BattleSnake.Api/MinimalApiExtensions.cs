namespace BattleSnake.Api;

public static class MinimalApiExtensions
{
    public static WebApplication MediateGet<TRequest>(this WebApplication webApplication, string template) where TRequest : IHttpRequest
    {
        webApplication.MapGet(template, async (IMediator mediator, [AsParameters] TRequest request) => await mediator.Send(request));
        return webApplication;
    }

    public static WebApplication MediatePost<TRequest>(this WebApplication webApplication, string template) where TRequest : IHttpRequest
    {
        webApplication.MapPost(template, async (IMediator mediator, [AsParameters] TRequest request) => await mediator.Send(request));
        return webApplication;
    }
}
