var builder = WebApplication.CreateBuilder(args);

Assembly assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    config.AddOpenBehavior(typeof(LoggingBehavior<,>));

});
builder.Services.AddValidatorsFromAssembly(assembly);


builder.Services.AddCarter();


builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

if (builder.Environment.IsDevelopment())
    builder.Services.InitializeMartenWith<CatalogIn�t�alData>();


builder.Services.AddExceptionHandler<CustomExceptionHandler>();


var app = builder.Build();

app.MapCarter();

app.UseExceptionHandler(options => { });

app.Run();
