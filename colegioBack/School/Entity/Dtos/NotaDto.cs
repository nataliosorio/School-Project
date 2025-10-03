using Entity.Dtos.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class NotaDto : Base
    {
        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }
        public int PeriodoId { get; set; }
        public decimal Valor { get; set; }

        public string? EstudianteNombre { get; set; }
        public string? AsignaturaNombre { get; set; }
        public string? PeriodoNombre { get; set; }
    }
}
