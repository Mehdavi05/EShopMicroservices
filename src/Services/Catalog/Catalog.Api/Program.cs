var builder = WebApplication.CreateBuilder(args);

//Add services to the Container(DI).
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

//Configure the http Request Pipeline.
app.MapCarter();

app.Run();