using Entity.Dtos.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class ColegioDto : Base
    {
        public string Nombre { get; set; } = null!;
        public int MaxEstudiantes { get; set; }
        public int MaxCursos { get; set; }
    }
}
