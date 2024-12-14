using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Services.Strategies;

public interface IOrderStrategy
{
    void CreateOrder(Order order);
    Order ReadOrder(int id);
    void UpdateOrder(Order order);
    void DeleteOrder(int id);
}