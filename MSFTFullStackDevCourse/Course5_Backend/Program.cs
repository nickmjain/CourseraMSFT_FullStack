using Course5_Backend.Services;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register services with different lifetimes
builder.Services.AddSingleton<IMyService, MyService>();
//builder.Services.AddScoped<IMyService, MyService>();
//builder.Services.AddTransient<IMyService, MyService>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("point 1");
    var myService = context.RequestServices.GetRequiredService<IMyService>();
    myService.LogCreation("First middleware");
    await next.Invoke();
    Console.WriteLine("point 2");
});

app.Use(async (context, next) =>
{
    Console.WriteLine("point 3");
    var myService = context.RequestServices.GetRequiredService<IMyService>();
    myService.LogCreation("Second middleware");
    await next.Invoke();
    Console.WriteLine("point 4");
});

app.Use(async (context, next) =>
{
    Console.WriteLine("point 5");
    await next.Invoke();
    Console.WriteLine("point 6");
});

app.MapGet("/", (IMyService myService) =>
{
    myService.LogCreation("Root");

    return Results.Ok("Check the console for service creation logs");
});

app.MapGet("/downloads", () => "downloads");
app.MapPut("/", () => "This is a put");
app.MapDelete("/", () => "This is a Delete");
app.MapPost("/", () => "This is a post");

app.MapControllers(); // Add this line

app.Run();