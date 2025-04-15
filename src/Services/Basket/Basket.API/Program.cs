

var builder = WebApplication.CreateBuilder(args);
Assembly assembly = typeof(Program).Assembly;

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    config.AddOpenBehavior(typeof(LoggingBehavior<,>));

});


builder.Services.AddCarter();

var app = builder.Build();
app.MapCarter();

app.Run();
