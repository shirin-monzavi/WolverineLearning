using WolverineLearning.Features.Orders.Command;

namespace WolverineLearning.Services;

public interface IOrderService
{
    Task<int> CreateAsync(
        CreateOrderCommand command,
        CancellationToken cancellationToken);
}
