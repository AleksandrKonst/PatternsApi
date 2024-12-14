using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Services.Strategies.Decorators;

public abstract class OrderStrategyDecorator : IOrderStrategy
{
    protected readonly IOrderStrategy _decoratedStrategy;
    
    protected OrderStrategyDecorator(IOrderStrategy decoratedStrategy)
    {
        _decoratedStrategy = decoratedStrategy;
    }
    
    public virtual void CreateOrder(Order order)
    {
        _decoratedStrategy.CreateOrder(order);
    }

    public virtual Order ReadOrder(int id)
    {
        return _decoratedStrategy.ReadOrder(id);
    }

    public virtual void UpdateOrder(Order order)
    {
        _decoratedStrategy.UpdateOrder(order);
    }

    public virtual void DeleteOrder(int id)
    {
        _decoratedStrategy.DeleteOrder(id);
    }
}