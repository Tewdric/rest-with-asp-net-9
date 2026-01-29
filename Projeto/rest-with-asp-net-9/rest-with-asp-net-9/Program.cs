using rest_with_asp_net_9.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<MathService>();


// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
