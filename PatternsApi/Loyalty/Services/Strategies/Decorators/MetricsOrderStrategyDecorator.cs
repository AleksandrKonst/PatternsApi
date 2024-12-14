using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Services.Strategies.Decorators;

public class MetricsOrderStrategyDecorator : OrderStrategyDecorator
{
    public MetricsOrderStrategyDecorator(IOrderStrategy decoratedStrategy)
        : base(decoratedStrategy)
    {
    }

    public override void CreateOrder(Order order)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        _decoratedStrategy.CreateOrder(order);
        stopwatch.Stop();
        
        Console.WriteLine($"CreateOrder: {stopwatch.ElapsedMilliseconds}ms");
    }

    public override Order ReadOrder(int id)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        var result = _decoratedStrategy.ReadOrder(id);
        stopwatch.Stop();
        
        Console.WriteLine($"ReadOrder: {stopwatch.ElapsedMilliseconds}ms");
        return result;
    }

    public override void UpdateOrder(Order order)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        _decoratedStrategy.UpdateOrder(order);
        stopwatch.Stop();
        
        Console.WriteLine($"UpdateOrder: {stopwatch.ElapsedMilliseconds}ms");
    }

    public override void DeleteOrder(int id)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        _decoratedStrategy.DeleteOrder(id);
        stopwatch.Stop();
        
        Console.WriteLine($"DeleteOrder: {stopwatch.ElapsedMilliseconds}ms");
    }
}