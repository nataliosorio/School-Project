using Entity.Dtos.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class AsignaturaDto : Base
    {
        public int MateriaId { get; set; }
        public int CursoId { get; set; }

        public string? MateriaNombre { get; set; }
        public string? CursoNombre { get; set; }
    }
}
