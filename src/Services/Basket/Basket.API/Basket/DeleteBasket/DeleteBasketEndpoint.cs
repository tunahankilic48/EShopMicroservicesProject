
namespace Basket.API.Basket.DeleteBasket
{
    //public record DeleteBasketRequest(string UserName) : ICommand<DeleteBasketResult>;
    public record DeleteBasketResponse(bool IsSuccess);
    public class DeleteBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/products/{userName}", async (string userName, ISender sender) =>
            {
                DeleteBasketResult result = await sender.Send(new DeleteBasketCommand(userName));
                DeleteBasketResponse response = result.Adapt<DeleteBasketResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteBasket")
            .Produces<DeleteBasketResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Delete Basket")
            .WithDescription("Delete Basket");
        }
    }
}
