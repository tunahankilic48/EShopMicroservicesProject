﻿using Ordering.Application.Orders.Queries.GetOrdersByName;

namespace Ordering.API.Endpoints
{
    //public record GetOrdersByNameRequest(string OrderName);
    public record GetOrdersByNameResponse(IEnumerable<OrderDto> Orders);
    public class GetOrdersByName : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/orders/{orderName}", async (string orderName, ISender sender) =>
            {
                GetOrdersByNameResult result = await sender.Send(new GetOrdersByNameQuery(orderName));
                GetOrdersByNameResponse response = result.Adapt<GetOrdersByNameResponse>();

                return Results.Ok(response);
            }).WithName("GetOrdersByName")
               .Produces<DeleteOrderResponse>(StatusCodes.Status200OK)
               .ProducesProblem(StatusCodes.Status400BadRequest)
               .ProducesProblem(StatusCodes.Status404NotFound)
               .WithSummary("Get Orders By Name")
               .WithDescription("Get Orders By Name");
        }
    }
}