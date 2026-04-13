using BibliotecaApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Repositório em memória (Singleton para manter dados entre requisições)
builder.Services.AddSingleton<BibliotecaRepository>();

builder.Services.AddControllers();

// TODO: Configurar Swagger/OpenAPI aqui (Passo 2)

var app = builder.Build();

// TODO: Adicionar middlewares do Swagger aqui (Passo 3)

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
