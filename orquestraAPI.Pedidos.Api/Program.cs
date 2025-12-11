using orquestraAPI.Pedidos.Application.Services;
using orquestraAPI.Pedidos.Domain.Interfaces;
using orquestraAPI.Pedidos.Infrastructure.Repositories;
 

var builder = WebApplication.CreateBuilder(args);

// ================================
// Registrando controllers
// ================================
builder.Services.AddControllers(); // registra todos os controllers no mesmo assembly

// ================================
// Configuração do Swagger/OpenAPI
// ================================
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // não precisamos de OpenApiInfo aqui

// ================================
// Injeção de dependência
// ================================
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ProdutoService>();

var app = builder.Build();

// ================================
// Pipeline HTTP
// ================================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();       // ativa JSON do Swagger
    app.UseSwaggerUI();     // ativa interface do Swagger em /swagger
}

app.UseHttpsRedirection();

// Mapear os controllers automaticamente
app.MapControllers();

app.Run();
