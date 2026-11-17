using Wolverine;
using WolverineLearning.Features.Orders.Command;
using WolverineLearning.Features.Orders.EventHandler;
using WolverineLearning.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseWolverine(opts =>
{
    opts.UseRuntimeCompilation();
    opts.Discovery.IncludeAssembly(
           typeof(UpdateInventoryHandler).Assembly);
    opts.MultipleHandlerBehavior =
       MultipleHandlerBehavior.Separated;
    opts.LocalQueueFor<UpdateInventoryCommand>()
    .Sequential();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
