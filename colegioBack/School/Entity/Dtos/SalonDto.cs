using Entity.Dtos.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class SalonDto : Base
    {
        public string Nombre { get; set; } = null!;
        public int Capacidad { get; set; }
    }
}
