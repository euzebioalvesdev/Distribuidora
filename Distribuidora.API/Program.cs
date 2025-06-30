using Distribuidora.Application.Mappings;
using Distribuidora.Application.UseCases.Cliente;
using Distribuidora.Application.UseCases.Produto;
using Distribuidora.Core.Interfaces;
using Distribuidora.Infrastructure.Context;
using Distribuidora.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra o DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona o escopos
builder.Services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

// Registra os Use Cases
builder.Services.AddScoped<CriarProdutoUseCase>();
builder.Services.AddScoped<AtualizarProdutoUseCase>();
builder.Services.AddScoped<ObterTodosProdutosUseCase>();
builder.Services.AddScoped<ObterProdutoPorIdUseCase>();
builder.Services.AddScoped<RemoverProdutoUseCase>();

builder.Services.AddScoped<CriarClienteUseCase>();
builder.Services.AddScoped<AtualizarClienteUseCase>();
builder.Services.AddScoped<ObterTodosClientesUseCase>();
builder.Services.AddScoped<ObterClientePorIdUseCase>();
builder.Services.AddScoped<RemoverClienteUseCase>();

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Distribuidora API v1");
        c.RoutePrefix = string.Empty; // Deixa acessível em http://localhost:xxxx/
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
