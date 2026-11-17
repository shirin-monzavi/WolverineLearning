namespace WolverineLearning.Features.Customers.Command;

public class RegisterCustomerHandler
{
    public async Task Handle(
        RegisterCustomerCommand command)
    {
        Console.WriteLine("Registering customer...");

        await Task.Delay(100);

        Console.WriteLine(
            $"Name: {command.FullName}");

        Console.WriteLine(
            $"Phone: {command.PhoneNumber}");

        Console.WriteLine("Customer registered!");
    }
}