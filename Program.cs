using AutoMapper;
using estudos_automapper;
using estudos_automapper.Models;
using estudos_automapper.ViewModel;

// Início da configuração
var builder = WebApplication.CreateBuilder(args);

var config = new MapperConfiguration(cfg => {
                                        cfg.CreateMap<Usuario, UsuarioViewModel>()
                                        .ForMember(uv => uv.Idade,
                                            m => m.MapFrom(a => CalcularIdade.Calcular(a.DataNascimento))
                                        );
                                    });
            
IMapper mapper = config.CreateMapper();
//fim da configuração

// injetando o objeto.
builder.Services.AddSingleton(mapper);

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
