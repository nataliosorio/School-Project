using Entity.Dtos.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class EstudianteDto : Base
    {
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public int CursoId { get; set; }

        public string? CursoNombre { get; set; }
    }
}
