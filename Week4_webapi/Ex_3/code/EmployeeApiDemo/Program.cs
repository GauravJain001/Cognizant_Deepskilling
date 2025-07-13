using EmployeeApiDemo.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(CustomExceptionFilter)); // Register global exception filter
});

builder.Services.AddScoped<CustomAuthFilter>(); // Register custom auth filter

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();
