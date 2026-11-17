namespace WolverineLearning.Features.Orders.Command;

public record CreateOrderCommand(
    int CustomerId,
    decimal Amount
);