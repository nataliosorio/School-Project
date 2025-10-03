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
    public class EstudianteService : BusinessGeneric<Estudiante,EstudianteDto> , IEstudianteService
    {
        private readonly ILogger<EstudianteService> _logger;
        protected readonly IEstudianteRepository _data;

        public EstudianteService(IEstudianteRepository data, ILogger<EstudianteService> logger, IMapper mapper) : base(data, mapper)
        {
            _data = data;
            _logger = logger;
        }
    }
}
