
using Entity.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class Asignatura : BaseModel
    {
        public int MateriaId { get; set; }
        public int CursoId { get; set; }

        public Materia Materia { get; set; } = null!;
        public Curso Curso { get; set; } = null!;

        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }
}
