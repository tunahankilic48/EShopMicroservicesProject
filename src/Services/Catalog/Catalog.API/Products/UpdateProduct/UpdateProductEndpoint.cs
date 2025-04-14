﻿namespace Catalog.API.Products.UpdateProduct
{
    public record UpdateProductRequest(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price) : ICommand<UpdateProductResult>;
    public record UpdateProductResponse(bool IsSuccess);
    public class UpdateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/products", async (UpdateProductRequest request, ISender sender) =>
            {
                UpdateProductCommand command = request.Adapt<UpdateProductCommand>();
                UpdateProductResult result = await sender.Send(command);
                UpdateProductResponse response = result.Adapt<UpdateProductResponse>();

                return Results.Ok(response);
            })
                .WithName("UpdateProduct")
                .Produces<UpdateProductResponse>(StatusCodes.Status201Created)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Update Product")
                .WithDescription("Update Product");
        }
    }
}
