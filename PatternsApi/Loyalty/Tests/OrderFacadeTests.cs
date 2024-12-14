using Moq;
using PatternsApi.Loyalty.Services;
using PatternsApi.Loyalty.Services.Strategies;
using PatternsApi.Loyalty.Tests.Builders;
using Xunit;

namespace PatternsApi.Loyalty.Tests;

public class OrderFacadeTests
{
    private readonly Mock<IOrderStrategy> _mockOrderStrategy;
    private readonly OrderFacade _orderFacade;

    public OrderFacadeTests()
    {
        _mockOrderStrategy = new Mock<IOrderStrategy>();
        _orderFacade = new OrderFacade(_mockOrderStrategy.Object);
    }

    [Fact]
    public void CreateOrder_ShouldCallCreateOrderOnStrategy()
    {
        // Arrange
        var order = new RegularOrderBuilder()
            .WithId(1)
            .WithCustomerName("Test Name")
            .Build();

        // Act
        _orderFacade.CreateOrder(order);

        // Assert
        _mockOrderStrategy.Verify(s => s.CreateOrder(order), Times.Once);
    }

    [Fact]
    public void ReadOrder_ShouldCallReadOrderOnStrategy()
    {
        // Arrange
        int orderId = 1;
        var expectedOrder = new RegularOrderBuilder()
            .WithId(orderId)
            .Build();
        
        _mockOrderStrategy.Setup(s => s.ReadOrder(orderId)).Returns(expectedOrder);

        // Act
        var order = _orderFacade.ReadOrder(orderId);

        // Assert
        _mockOrderStrategy.Verify(s => s.ReadOrder(orderId), Times.Once);
        Assert.Equal(expectedOrder, order);
    }

    [Fact]
    public void UpdateOrder_ShouldCallUpdateOrderOnStrategy()
    {
        // Arrange
        var order = new RegularOrderBuilder()
            .WithId(1)
            .WithCustomerName("Test Name")
            .Build();

        // Act
        _orderFacade.UpdateOrder(order);

        // Assert
        _mockOrderStrategy.Verify(s => s.UpdateOrder(order), Times.Once);
    }

    [Fact]
    public void DeleteOrder_ShouldCallDeleteOrderOnStrategy()
    {
        // Arrange
        int orderId = 1;

        // Act
        _orderFacade.DeleteOrder(orderId);

        // Assert
        _mockOrderStrategy.Verify(s => s.DeleteOrder(orderId), Times.Once);
    }
}