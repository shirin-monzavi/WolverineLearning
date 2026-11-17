using WolverineLearning.Features.Orders.Command;

namespace WolverineLearning.Features.Orders.EventHandler;

public class SendOrderNotificationHandler
{
    public Task Handle(OrderCreated message)
    {
        Console.WriteLine(
            $"Sending notification for order {message.OrderId}");

        return Task.CompletedTask;
    }
}