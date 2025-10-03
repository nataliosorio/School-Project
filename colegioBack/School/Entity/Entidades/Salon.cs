
using Entity.Entidades.Base;
using System;
using System.Collections.Generic;

namespace Entity.Entidades
{
    public class Salon : BaseModel
    {
        public string Nombre { get; set; } = null!;

        // Configuración
        public int Capacidad { get; set; }

        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
