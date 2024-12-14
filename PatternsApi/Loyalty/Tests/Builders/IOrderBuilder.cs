using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Tests.Builders;

public interface IOrderBuilder<T> where T : Order
{
    IOrderBuilder<T> WithId(int id);
    IOrderBuilder<T> WithCustomerName(string customerName);
    IOrderBuilder<T> WithOrderDate(DateTime orderDate);
    T Build();
}