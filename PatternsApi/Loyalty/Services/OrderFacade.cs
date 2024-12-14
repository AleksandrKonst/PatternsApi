using PatternsApi.Loyalty.Models;
using PatternsApi.Loyalty.Services.Strategies;

namespace PatternsApi.Loyalty.Services;

public class OrderFacade : IOrderFacade
{
    private readonly IOrderStrategy _orderStrategy;

    public OrderFacade(IOrderStrategy orderStrategy)
    {
        _orderStrategy = orderStrategy;
    }

    public void CreateOrder(Order order)
    {
        _orderStrategy.CreateOrder(order);
    }

    public Order ReadOrder(int id)
    {
        return _orderStrategy.ReadOrder(id);
    }

    public void UpdateOrder(Order order)
    {
        _orderStrategy.UpdateOrder(order);
    }

    public void DeleteOrder(int id)
    {
        _orderStrategy.DeleteOrder(id);
    }
}