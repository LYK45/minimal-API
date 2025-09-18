using Microsoft.EntityFrameworkCore;
using MinimalApi.Infraestrutura.Db;
using MinimalApi.DTOs;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

app.MapGet("/", () => "Quem ler sabe. que o Lucas é lindo e gostoso");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) =>
{
    if (administradorServico.Login(loginDTO) != null)
    {
        return Results.Ok("Login feito com Sucesso!");
    }
    else
    {
        return Results.Unauthorized();
    }
});


app.Run();




// Classes





