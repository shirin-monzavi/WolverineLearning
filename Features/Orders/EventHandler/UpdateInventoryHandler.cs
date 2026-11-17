using WolverineLearning.Features.Orders.Command;

namespace WolverineLearning.Features.Orders.EventHandler;

public class UpdateInventoryHandler
{
    public async Task Handle(UpdateInventoryCommand command)
    {
        Console.WriteLine(
                $"Started: {command.OrderId} - {DateTime.Now:HH:mm:ss.fff}");

        await Task.Delay(5000);

        Console.WriteLine(
            $"Finished: {command.OrderId} - {DateTime.Now:HH:mm:ss.fff}");
    }
}
