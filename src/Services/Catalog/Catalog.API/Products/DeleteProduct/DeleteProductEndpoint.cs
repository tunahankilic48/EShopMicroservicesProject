namespace Catalog.API.Products.DeleteProduct
{
    //public record DeleteProductRequest(Guid Id) :ICommand<DeleteProductResult>;
    public record DeleteProductResponse(bool IsSuccess);
    public class DeleteProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/products/{id}", async (Guid id, ISender sender) =>
            {
                DeleteProductResult result = await sender.Send(new DeleteProductCommand(id));
                DeleteProductResponse response = result.Adapt<DeleteProductResponse>();

                return Results.Ok(response);
            })
                .WithName("DeleteProduct")
                .Produces<DeleteProductResponse>(StatusCodes.Status201Created)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Delete Product")
                .WithDescription("Delete Product");
        }
    }
}
