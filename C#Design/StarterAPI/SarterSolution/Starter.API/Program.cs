using Microsoft.EntityFrameworkCore;
using Starter.Infrastructure;
using Starter.Infrastructure.Persistence.Context;
using Starter.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureInfrastructure(builder.Configuration);
builder.Services.ConfigureApplication();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

var serviceScope = app.Services.CreateScope();
var dataContext = serviceScope.ServiceProvider.GetService<DataContext>();
await dataContext?.Database.MigrateAsync();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
