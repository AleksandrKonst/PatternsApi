using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Services.Strategies;

public class SpecialOrderStrategy : IOrderStrategy
{
    public void CreateOrder(Order order)
    {
        Console.WriteLine("Создан специальный заказ");
    }

    public Order ReadOrder(int id)
    {
        Console.WriteLine("Чтение специального заказа");
        return new Order();
    }

    public void UpdateOrder(Order order)
    {
        Console.WriteLine("Обновлен специальный заказ");
    }

    public void DeleteOrder(int id)
    {
        Console.WriteLine("Удален специальный заказ");
    }
}