using BibliotecaApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Repositório em memória (Singleton para manter dados entre requisições)
builder.Services.AddSingleton<BibliotecaRepository>();
builder.Services.AddControllers();

// Passo 2 — registrar os serviços do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Passo 3 — adicionar os middlewares do Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();