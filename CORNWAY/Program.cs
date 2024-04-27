using CORNWAY.Repositories;
using CORNWAY.Services;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add scoped repositories
builder.Services.AddScoped<IArmaRepository, ArmaRepository>();
builder.Services.AddScoped<IEnemigoRepository, EnemigoRepository>();
builder.Services.AddScoped<IFertilizanteRepository, FertilizanteRepository>();
builder.Services.AddScoped<IHerramientaRepository, HerramientaRepository>();
builder.Services.AddScoped<IMascotaRepository, MascotaRepository>();
builder.Services.AddScoped<IPersonajeRepository, PersonajeRepository>();
builder.Services.AddScoped<ISemillaRepository, SemillaRepository>();
builder.Services.AddScoped<ISensorRepository, SensorRepository>();
builder.Services.AddScoped<ITerrenoRepository, TerrenoRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITipoUserRepository, TipoUserRepository>();
builder.Services.AddScoped<ILogroRepository, LogroRepository>();

//add scoped services
builder.Services.AddScoped<IArmaService, ArmaService>();
builder.Services.AddScoped<IEnemigoService, EnemigoService>();
builder.Services.AddScoped<IFertilizanteService, FertilizanteService>();
builder.Services.AddScoped<IHerramientaService, HerramientaService>();
builder.Services.AddScoped<IMascotaService, MascotaService>();
builder.Services.AddScoped<IPersonajeService, PersonajeService>();
builder.Services.AddScoped<ISemillaService, SemillaService>();
builder.Services.AddScoped<ISensorService, SensorService>();
builder.Services.AddScoped<ITerrenoService, TerrenoService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITipoUserService, TipoUserService>();
builder.Services.AddScoped<ILogroService, LogroService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
