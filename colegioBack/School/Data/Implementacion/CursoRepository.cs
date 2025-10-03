using Data.Interfaz;
using Data.repository;
using Entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementacion
{
    public class CursoRepository : DataGeneric<Curso>,ICursoRepository
    {
        public CursoRepository(SchoolDbContext context) : base(context)
        {
        }
    }
}
