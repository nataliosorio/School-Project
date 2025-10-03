using Data;
using Data.service;
using Data.repository;
using Business.Services.ImplementacionGenericos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Agregar servicios de ASP.NET Core
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 Conexión a la BD (SQL Server)
builder.Services.AddDbContext<SchoolDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔹 Registro genérico del repositorio y capa business
builder.Services.AddScoped(typeof(IData<>), typeof(DataGeneric<>));
builder.Services.AddScoped(typeof(BusinessGeneric<,>));

// 🔹 AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// 🔹 🔥 Configuración de CORS 🔥
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirFrontend", policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:4200", // Angular
                "http://localhost:8100"  // Ionic
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// 🔹 Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Colegio v1");
        c.RoutePrefix = "swagger"; // acceso en http://localhost:5185/swagger
    });
}

app.UseHttpsRedirection();

// ⚡ Habilita la política CORS ANTES de los controladores
app.UseCors("PermitirFrontend");

app.UseAuthorization();
app.MapControllers();

app.Run();
