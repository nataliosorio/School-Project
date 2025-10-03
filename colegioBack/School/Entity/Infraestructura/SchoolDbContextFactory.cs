using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Entity.Infraestructura
{
    public class SchoolDbContextFactory : IDesignTimeDbContextFactory<SchoolDbContext>
    {
        public SchoolDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();

            // 🔹 Aquí configuras tu proveedor (ejemplo SQL Server)
            optionsBuilder.UseSqlServer("Server=LAPTOP-DDPC2U6E;Database=SchoolDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

            return new SchoolDbContext(optionsBuilder.Options);
        }
    }
}
