using Entity.Entidades;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<Colegio> Colegios => Set<Colegio>();
        public DbSet<Curso> Cursos => Set<Curso>();
        public DbSet<Estudiante> Estudiantes => Set<Estudiante>();
        public DbSet<Materia> Materias => Set<Materia>();
        public DbSet<Asignatura> Asignaturas => Set<Asignatura>();
        public DbSet<Periodo> Periodos => Set<Periodo>();
        public DbSet<Nota> Notas => Set<Nota>();
        public DbSet<Salon> Salones => Set<Salon>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Precision para decimales
            modelBuilder.Entity<Periodo>()
                .Property(p => p.Porcentaje)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Nota>()
                .Property(n => n.Valor)
                .HasPrecision(18, 2);

            // ✅ Relación Nota - Asignatura
            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Asignatura)
                .WithMany(a => a.Notas) // Usa la colección en Asignatura
                .HasForeignKey(n => n.AsignaturaId)
                .OnDelete(DeleteBehavior.Restrict);

            // ✅ Relación Nota - Periodo
            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Periodo)
                .WithMany(p => p.Notas) // Usa la colección en Periodo
                .HasForeignKey(n => n.PeriodoId)
                .OnDelete(DeleteBehavior.Restrict);

            // ✅ Relación Nota - Estudiante
            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Estudiante)
                .WithMany(e => e.Notas)
                .HasForeignKey(n => n.EstudianteId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
