
using MetalCoin.Api.Data;
using MetalCoin.Api.Repositorios;
using MetalCoin.Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Configuração do banco de dados SQL Server
builder.Services.AddDbContext<SistemaProdutoDBContex>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlServer"));
});
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>
{
    options.AllowAnyOrigin(); // Permitir todas as origens
    options.AllowAnyMethod(); // Permitir todos os métodos (GET, POST, PUT, DELETE, etc.)
    options.AllowAnyHeader(); // Permitir todos os cabeçalhos
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
