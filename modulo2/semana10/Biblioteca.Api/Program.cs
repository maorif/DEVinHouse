
using Biblioteca.Core.Entities;
using Biblioteca.Api.Interfaces;
using Biblioteca.Api.Services;

// Exercicio 2.6:
var livro = new Livro();

var builder = WebApplication.CreateBuilder(args);

// Exercicio 9: Injeção de depêndecias
builder.Services.AddScoped<IAmbienteService, AmbienteService>();

// Add services to the container.

builder.Services.AddCors();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

// Exercício 5
app.UseCors(builder => builder
    .SetIsOriginAllowed(origin => true)
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapControllers();

app.Run();
