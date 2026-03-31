using TalentInsights.Application.Interfaces.Services;
using TalentInsights.Application.Models.DTOs;
using TalentInsights.Application.Services;
using TalentInsights.Shared;
using Microsoft.EntityFrameworkCore;
using TalentInsights.Domain.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Database
builder.Services.AddDbContext<TalentInsights.Domain.Database.TalentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Services
builder.Services.AddScoped<ICollaboratorService, CollaboratorService>();

builder.Services.AddSingleton<Cache<CollaboratorDto>>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddSingleton<Cache<UserDto>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
