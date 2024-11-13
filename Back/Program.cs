using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Repository.Repositories;
using Back.Data.Service.Interfaces;
using Back.Data.Service.Services;
using Back.Utilities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CineDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MiConexion")));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ITransaccionRepository, TransaccionRepository>();
builder.Services.AddScoped<ITransaccionService, TransaccionService>();
builder.Services.AddScoped<IFuncionRepository, FuncionRepository>();
builder.Services.AddScoped<IFuncionService, FuncionService>();
builder.Services.AddScoped<IPeliculasRepository, PeliculaRepository>();
builder.Services.AddScoped<IPeliculaService, PeliculaService>();
builder.Services.AddScoped<IUtils, Utils>();
builder.Services.AddScoped<IClasificacionEdad,ClasificacionEdadRepository>();
builder.Services.AddScoped<IClasificacionEdadService, ClasificacionEdadService>();
builder.Services.AddScoped<IDirectorRepository, DirectorRepository>();
builder.Services.AddScoped<IDirectorService, DirectoresService>();
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IGeneroService, GeneroService>();
builder.Services.AddScoped<IDiomaRepository,IdiomaRepository>();
builder.Services.AddScoped<IIdiomaService, IdiomaService>();
builder.Services.AddScoped<ISalaRepository , SalaRepository>();
builder.Services.AddScoped<ISalaService , SalaService>();
builder.Services.AddScoped<IPromocionesService , PromocionesService>();
builder.Services.AddScoped<IPromocionesRespository, PromocionesRespository>();
builder.Services.AddScoped<ITpFuncionRepository , TpFuncionRepository>();
builder.Services.AddScoped<ITpFuncionesService , TpFuncionesService>();
builder.Services.AddScoped<IUtilsFuncion, UtilsFuncion>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("CORS", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

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

app.UseCors("CORS");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
