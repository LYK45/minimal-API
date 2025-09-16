using Microsoft.EntityFrameworkCore;
using MinimalApi.Infraestrutura.Db;
using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

app.MapGet("/", () => "Quem ler sabe. que o Lucas é lindo e gostoso");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
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





