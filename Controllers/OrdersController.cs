namespace WolverineLearning.Controllers;

using global::WolverineLearning.Features.Orders.Command;
using Microsoft.AspNetCore.Mvc;
using Wolverine;
using WolverineLearning.Features.Orders;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IMessageBus _messageBus;

    public OrdersController(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        CreateOrderCommand command)
    {
        await _messageBus.InvokeAsync(command);

        return Ok("Order created successfully");
    }
}