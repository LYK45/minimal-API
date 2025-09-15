var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Quem ler sabe. que o Lucas é lindo e gostoso");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDTO) =>
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





