using Entity.Dtos.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class CursoDto : Base
    {
        public string Nombre { get; set; } = null!;

        public int ColegioId { get; set; }
        public int SalonId { get; set; }
        public int MaxEstudiantes { get; set; }

        public string? ColegioNombre { get; set; }
        public string? SalonNombre { get; set; }
    }
}
