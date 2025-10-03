using Entity.Entidades.Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class Curso : BaseModel
    {
        public string Nombre { get; set; } = null!;
        public int MaxEstudiantes { get; set; }

        // FK
        public int ColegioId { get; set; }
        public int SalonId { get; set; }
        public Colegio Colegio { get; set; } = null!;
        public Salon Salon { get; set; } = null!;

        public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
        public ICollection<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }
}
