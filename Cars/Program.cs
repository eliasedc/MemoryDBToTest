//using Microsoft.EntityFrameworkCore

using DBRepository.Model;
using Microsoft.EntityFrameworkCore;
using Domain.Extensions;
using DBRepository.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDependencyInjectionDomain()
                .AddDependencyInjectionRepository()
                .AddDbContext<EliasdcDevContext>(options =>{
                                                             //Get ConnectionString from appsettings.json
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DB"));
                });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
