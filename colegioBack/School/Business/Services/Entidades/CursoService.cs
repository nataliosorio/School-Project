using AutoMapper;
using Business.interfaz.Entidades;
using Business.Services.ImplementacionGenericos;
using Data.Interfaz;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entidades
{
    public class CursoService : BusinessGeneric<Curso,CursoDto>,ICursoService
    {
        private readonly ILogger<ColegioService> _logger;
        protected readonly ICursoRepository _data;

        public CursoService(ILogger<ColegioService> logger, ICursoRepository data , IMapper mapper) : base(data,mapper)
        {
            _logger = logger;
            _data = data;
        }
    }
}
