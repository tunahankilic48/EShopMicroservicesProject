using BuildingBlocks.Messaging.Events;
using MassTransit;
using Ordering.Application.Orders.Commands.CreateOrder;

namespace Ordering.Application.Orders.EventHandlers.Integration
{
    public class BasketCheckoutEventHandler(ISender sender, ILogger<BasketCheckoutEventHandler> logger) : IConsumer<BasketCheckoutEvent>
    {
        public async Task Consume(ConsumeContext<BasketCheckoutEvent> context)
        {
            logger.LogInformation("Integration Event Handler: {IntegrationEvent}", context.Message.GetType().Name);

            CreateOrderCommand command = MapToCreateOrderCommand(context.Message);
            await sender.Send(command);

        }

        private CreateOrderCommand MapToCreateOrderCommand(BasketCheckoutEvent message)
        {
            AddressDto addressDto = new AddressDto(message.FirstName, message.LastName,message.EmailAddress,message.AddressLine, message.Country, message.State, message.ZipCode);
            PaymentDto paymentDto = new PaymentDto(message.CardName, message.CardNumber, message.Expiration, message.Cvv, message.PaymentMethod);
            Guid orderId = Guid.NewGuid();

            OrderDto orderDto = new OrderDto(
                orderId,
                message.CustomerId,
                message.UserName,
                addressDto,
                addressDto,
                paymentDto,
                OrderStatus.Pending,
                [
                    new OrderItemDto(orderId, new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"), 2, 500),
                    new OrderItemDto(orderId, new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"), 1, 400)
                ]);

            return new CreateOrderCommand(orderDto);
        }
    }
}
