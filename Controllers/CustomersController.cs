namespace WolverineLearning.Controllers;

using global::WolverineLearning.Features.Customers.Command;
using Microsoft.AspNetCore.Mvc;
using Wolverine;
using WolverineLearning.Features.Customers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    private readonly IMessageBus _messageBus;

    public CustomersController(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    [HttpPost]
    public async Task<IActionResult> Register(
        RegisterCustomerCommand command)
    {
        await _messageBus.InvokeAsync(command);

        return Ok("");
    }
}