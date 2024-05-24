using MediatR;
using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.Application.UseCases.UserStories.Queries;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.Infrastructure;
using Spg.Spengergram.Repository.Builders;
using Spg.Spengergram.Repository.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//
// Configure DB Context
string? connectionString = builder.Configuration.GetConnectionString("SqLite");
builder.Services.AddDbContext<SqLiteDatabase>(o => o.UseSqlite(connectionString));
//
// Configure Services and Repositories
builder.Services.AddScoped<IReadOnlyUserRepository, ReadOnlyUserRepository>();
builder.Services.AddScoped<IUserFilterBuilder, UserFilterBuilder>(f =>
{
    return new UserFilterBuilder(f.GetRequiredService<SqLiteDatabase>().Users);
});
//
// Configure CorsPolicy
builder.Services.AddCors(options =>
{
    options.AddPolicy("allowSpecificOrigins", policy =>
    {
        policy.AllowAnyOrigin(); //.WithOrigins("http://localhost:4200");
    });
});
//
// Configure MediatR
builder.Services.AddMediatR(options =>
{
    options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});
builder.Services.AddTransient<IRequestHandler<GetUserFilteredModel, IQueryable<UserDto>>, GetUserFilteredHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("allowSpecificOrigins");
app.UseHttpsRedirection();
app.MapControllers();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
