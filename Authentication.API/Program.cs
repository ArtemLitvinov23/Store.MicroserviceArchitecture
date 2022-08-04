using Authentication.API.Repository;
using Authentication.API.Repository.Contracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
