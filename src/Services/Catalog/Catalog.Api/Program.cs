var builder = WebApplication.CreateBuilder(args);

//Add services to the Container(DI).

var app = builder.Build();

//Configure the http Request Pipeline.

app.Run();