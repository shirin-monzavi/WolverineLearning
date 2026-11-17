namespace WolverineLearning.Features.Orders.Command;

public record OrderCreated(
    int OrderId,
    int CustomerId,
    decimal Amount
);