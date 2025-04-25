namespace Ordering.Application.Orders.Commands.UpdateOrder
{
    public class UpdateOrderHandler(IApplicationDbContext dbContext) : ICommandHandler<UpdateOrderCommand, UpdateOrderResult>
    {
        public async Task<UpdateOrderResult> Handle(UpdateOrderCommand command, CancellationToken cancellationToken)
        {
            OrderId orderId = OrderId.Of(command.Order.Id);

            Order order = await dbContext.Orders.FindAsync([orderId], cancellationToken: cancellationToken);

            if  (order is null)
                throw new OrderNotFoundException(command.Order.Id);

            UpdateOrderWithNewValues(order, command.Order);
            
            dbContext.Orders.Update(order);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new UpdateOrderResult(true);
        }

        public void UpdateOrderWithNewValues(Order order, OrderDto orderDto)
        {
            Address shippingAddress = Address.Of(orderDto.ShippigAddress.FirstName, orderDto.ShippigAddress.LastName, orderDto.ShippigAddress.EmailAddress, orderDto.ShippigAddress.AddressLine, orderDto.ShippigAddress.Country, orderDto.ShippigAddress.State, orderDto.ShippigAddress.ZipCode);
            Address billingAddress = Address.Of(orderDto.BillingAddress.FirstName, orderDto.BillingAddress.LastName, orderDto.BillingAddress.EmailAddress, orderDto.BillingAddress.AddressLine, orderDto.BillingAddress.Country, orderDto.BillingAddress.State, orderDto.BillingAddress.ZipCode);
            Payment payment = Payment.Of(orderDto.Payment.CardName, orderDto.Payment.CardNumber, orderDto.Payment.Expiration, orderDto.Payment.Cvv, orderDto.Payment.PaymentMethod);

            order.Update(OrderName.Of(orderDto.OrderName), shippingAddress, billingAddress, payment, orderDto.Status);
        }
    }
}
