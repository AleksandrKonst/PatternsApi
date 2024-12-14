using Microsoft.AspNetCore.Mvc;
using PatternsApi.Loyalty.Models;
using PatternsApi.Loyalty.Services;
using PatternsApi.Loyalty.Services.Strategies;
using PatternsApi.Loyalty.Services.Strategies.Decorators;

namespace PatternsApi.Loyalty.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderFacade _orderFacade = new OrderFacade(
        new MetricsOrderStrategyDecorator(
            new RegularOrderStrategy()
            )
        );

    [HttpPost]
    [Route("create")]
    public IActionResult CreateOrder([FromBody] Order order)
    {
        _orderFacade.CreateOrder(order);
        return Ok("Order created successfully");
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetOrder(int id)
    {
        var order = _orderFacade.ReadOrder(id);
        if (order == null)
        {
            return NotFound("Order not found");
        }
        return Ok(order);
    }

    [HttpPut]
    [Route("update")]
    public IActionResult UpdateOrder([FromBody] Order order)
    {
        _orderFacade.UpdateOrder(order);
        return Ok("Order updated successfully");
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public IActionResult DeleteOrder(int id)
    {
        _orderFacade.DeleteOrder(id);
        return Ok("Order deleted successfully");
    }
}