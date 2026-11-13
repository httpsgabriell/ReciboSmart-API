using Microsoft.EntityFrameworkCore;
using ReciboSmart.API.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Ligar à base de dados SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Adicionar suporte para Controllers (é aqui que vamos validar e guardar os dados)
builder.Services.AddControllers();

// Configurações do Swagger (para podermos testar a API no browser)
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

// 3. Mapear os endpoints dos Controllers
app.MapControllers();

app.Run();