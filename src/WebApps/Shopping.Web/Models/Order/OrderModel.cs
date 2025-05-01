﻿namespace Shopping.Web.Models.Order
{
    public record OrderModel(Guid Id, Guid CustomerId, string OrderName, AddressModel ShippingAddress, AddressModel BillingAddress, PaymentModel Payment, OrderStatus Status, List<OrderItemModel> OrderItems);
    public record AddressModel(string FirstName, string LastName, string EmailAddress, string AddressLine, string Country, string State, string ZipCode);
    public record PaymentModel(string CardName, string CardNumber, string Expiration, string Cvv, int PaymentMethod);
    public record OrderItemModel(Guid OrderId, Guid ProductId, int Quantity, decimal Price);
    public enum OrderStatus
    {
        Draft = 1,
        Pending = 2,
        Completed = 3,
        Cancelled = 4
    }

    // Wrapper Classes
    public record GetOrdersResponse(PaginatedResult<OrderModel> Orders);
    public record GetOrdersByNameResponse(IEnumerable<OrderModel> Orders);
    public record GetOrdersByCustomerResponse(IEnumerable<OrderModel> Orders);
}
