namespace WolverineLearning.Features.Customers.Command;

public record RegisterCustomerCommand(
    string FullName,
    string PhoneNumber
);