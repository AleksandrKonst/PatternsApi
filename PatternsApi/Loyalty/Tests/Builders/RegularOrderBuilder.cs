using PatternsApi.Loyalty.Models;

namespace PatternsApi.Loyalty.Tests.Builders;

public class RegularOrderBuilder : IOrderBuilder<RegularOrder>
{
    private int _id = 1;
    private string _customerName = "Default Customer";
    private DateTime _orderDate = DateTime.Now;
    private bool _isGift = false;
    
    public IOrderBuilder<RegularOrder> WithId(int id)
    {
        _id = id;
        return this;
    }
    
    public IOrderBuilder<RegularOrder> WithCustomerName(string customerName)
    {
        _customerName = customerName;
        return this;
    }

    public IOrderBuilder<RegularOrder> WithOrderDate(DateTime orderDate)
    {
        _orderDate = orderDate;
        return this;
    }

    public RegularOrderBuilder WithIsGift(bool isGift)
    {
        _isGift = isGift;
        return this;
    }
    
    public RegularOrder Build()
    {
        return new RegularOrder
        {
            Id = _id,
            CustomerName = _customerName,
            OrderDate = _orderDate,
            IsGift = _isGift
        };
    }
}