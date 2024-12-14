using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Tests.Builders;

public class SpecialOrderBuilder : IOrderBuilder<SpecialOrder>
{
    private int _id = 1;
    private string _customerName = "Default Customer";
    private DateTime _orderDate = DateTime.Now;
    private string _specialInstructions = string.Empty;

    public IOrderBuilder<SpecialOrder> WithId(int id)
    {
        _id = id;
        return this;
    }
    
    public IOrderBuilder<SpecialOrder> WithCustomerName(string customerName)
    {
        _customerName = customerName;
        return this;
    }

    public IOrderBuilder<SpecialOrder> WithOrderDate(DateTime orderDate)
    {
        _orderDate = orderDate;
        return this;
    }

    public SpecialOrderBuilder WithSpecialInstructions(string instructions)
    {
        _specialInstructions = instructions;
        return this;
    }

    public SpecialOrder Build()
    {
        return new SpecialOrder
        {
            Id = _id,
            CustomerName = _customerName,
            OrderDate = _orderDate,
            SpecialInstructions = _specialInstructions
        };
    }
}