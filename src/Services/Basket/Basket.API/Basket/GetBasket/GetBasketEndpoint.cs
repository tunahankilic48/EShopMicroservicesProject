﻿namespace Basket.API.Basket.GetBasket
{
    //public record GetBasketRequest : IQuery
    public record GetBasketResponse(ShoppingCart Cart);
    public class GetBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/basket/{UserName}", async (string UserName, ISender sender) =>
            {
                GetBasketResult result = await sender.Send(new GetBasketQuery(UserName));
                GetBasketResponse response = result.Adapt<GetBasketResponse>();

                return Results.Ok(response);
            })
            .WithName("GetBasket")
            .Produces<GetBasketResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get Basket")
            .WithDescription("Get Basket");
        }
    }
}
