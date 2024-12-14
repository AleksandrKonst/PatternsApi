using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Services.Strategies;

public class RegularOrderStrategy : IOrderStrategy
{
    public void CreateOrder(Order order)
    {
        Console.WriteLine("Создан обычный заказ");
    }

    public Order ReadOrder(int id)
    {
        Console.WriteLine("Чтение обычного заказа");
        return new Order();
    }

    public void UpdateOrder(Order order)
    {
        Console.WriteLine("Обновлен обычный заказ");
    }

    public void DeleteOrder(int id)
    {
        Console.WriteLine("Удален обычный заказ");
    }
}