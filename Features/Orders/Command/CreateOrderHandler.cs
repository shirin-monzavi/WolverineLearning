using Wolverine;
using WolverineLearning.Services;

namespace WolverineLearning.Features.Orders.Command;

public class CreateOrderHandler
{
    public async Task Handle(
           CreateOrderCommand command,
           IOrderService orderService,
           IMessageBus bus,
           CancellationToken cancellationToken)
    {
        var orderId = await orderService.CreateAsync(
            command,
            cancellationToken);

        await bus.SendAsync(
    new UpdateInventoryCommand(orderId));
        //await bus.PublishAsync(
        //    new OrderCreated(
        //        orderId,
        //        command.CustomerId,
        //        command.Amount));
    }
}