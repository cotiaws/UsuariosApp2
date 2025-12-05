using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//Configuração para a documentação do Swagger
builder.Services.AddEndpointsApiExplorer(); //Swagger
builder.Services.AddSwaggerGen(); //Swagger

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//Executando os serviços do Swagger (documentação da API)
app.UseSwagger(); //Swagger
app.UseSwaggerUI(); //Swagger

//Executando os serviços do Scalar
app.MapScalarApiReference(s => s.WithTheme(ScalarTheme.BluePlanet));

app.UseAuthorization();
app.MapControllers();
app.Run();
