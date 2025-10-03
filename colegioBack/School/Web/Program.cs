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

// 🔹 Conexión a la BD (SQL Server en este caso)
builder.Services.AddDbContext<SchoolDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔹 Registro genérico del repositorio y capa business
builder.Services.AddScoped(typeof(IData<>), typeof(DataGeneric<>));
builder.Services.AddScoped(typeof(BusinessGeneric<,>));

// 🔹 Si quieres servicios específicos para cada entidad, también se registran aquí
// builder.Services.AddScoped<IColegioService, ColegioService>();
// builder.Services.AddScoped<IAsignaturaService, AsignaturaService>();
// builder.Services.AddScoped<INotaService, NotaService>();
// builder.Services.AddScoped<IPeriodoService, PeriodoService>();

// 🔹 AutoMapper (perfil que tengas configurado)
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

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
app.UseAuthorization();
app.MapControllers();

app.Run();
