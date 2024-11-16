using Microsoft.EntityFrameworkCore; // Necesario para DbContext y UseNpgsql
using ClientesAPI.Models;            // Necesario para ClientesDBContext

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddDbContext<ClientesDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // Configuración de la conexión a PostgreSQL

builder.Services.AddControllers(); // Agregar soporte para controladores
builder.Services.AddEndpointsApiExplorer(); // Agregar soporte para Swagger
builder.Services.AddSwaggerGen(); // Generar documentación de la API

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilitar Swagger en modo desarrollo
    app.UseSwaggerUI(); // Habilitar la interfaz de usuario de Swagger
}

app.UseHttpsRedirection(); // Redirigir automáticamente a HTTPS
app.UseAuthorization(); // Configurar autorización

app.MapControllers(); // Mapear controladores para las rutas de la API

app.Run(); // Iniciar la aplicación

