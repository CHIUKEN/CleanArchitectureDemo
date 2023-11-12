using CleanArchitectureDemo.UseCases.Demo.List;
using FastEndpoints;
using MediatR;

namespace CleanArchitectureDemo.Web.Demo;

public class GetAll : EndpointWithoutRequest
{
    private readonly IMediator _mediator;

    public GetAll(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        AllowAnonymous();
        Get("/demo/getall");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var r = await _mediator.Send(new ListQuery(), ct);
        await SendAsync(r, statusCode: 200, ct);
    }
}
