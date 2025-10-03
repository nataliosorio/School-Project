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
    public class MateriaService : BusinessGeneric<Materia,MateriaDto>, IMateriaService
    {
        private readonly ILogger<MateriaService> _logger;
        protected readonly IMateriaRepository _data;

        public MateriaService(IMateriaRepository data, ILogger<MateriaService> logger, IMapper mapper) : base(data, mapper )
        {
            _data = data;
            _logger = logger;
        }
    }
}
