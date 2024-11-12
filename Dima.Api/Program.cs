using Dima.Core.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/v1/transaction", (Transaction transaction) => "Hello World!");


app.Run();