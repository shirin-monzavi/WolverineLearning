using WolverineLearning.Features.Orders.Command;

namespace WolverineLearning.Services;

public class OrderService : IOrderService
{
    public Task<int> CreateAsync(
        CreateOrderCommand command,
        CancellationToken cancellationToken)
    {
        var orderId = Random.Shared.Next(1000, 9999);

        Console.WriteLine(
            $"Order created by service: {orderId}");

        return Task.FromResult(orderId);
    }
}