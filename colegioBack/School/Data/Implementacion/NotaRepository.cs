using Data.Interfaz;
using Data.repository;
using Data.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementacion
{
    public class NotaRepository : DataGeneric<Nota>,INotaRepository
    {
        public NotaRepository(SchoolDbContext context) : base(context)
        {
        }
    }
}
