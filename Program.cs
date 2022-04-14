using AutoMapper;
using AutoMapper.Configuration;
using estudos_automapper.Models;
using estudos_automapper.Extensions;
using estudos_automapper.ViewModel;
using estudos_automapper.AutoMapper;

// Início da configuração
var builder = WebApplication.CreateBuilder(args);

// injeção do automapper
// classes que herdam profile são injetadas
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
