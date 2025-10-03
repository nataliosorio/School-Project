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
    public class AsignaturaService : BusinessGeneric<Asignatura,AsignaturaDto>,IAsignaturaService
    {
        private readonly ILogger<AsignaturaService> _logger;
        protected readonly IAsignaturaRepository _data;

        public AsignaturaService(IAsignaturaRepository data, IMapper mapper,ILogger<AsignaturaService> logger) : base(data, mapper)
        {
            _data = data;
            _logger = logger;
        }
    }
}
