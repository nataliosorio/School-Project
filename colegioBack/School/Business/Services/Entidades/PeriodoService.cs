using AutoMapper;
using Business.Services.ImplementacionGenericos;
using Data.Interfaz;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.Extensions.Logging;

namespace Business.Services.Entidades
{
    public class PeriodoService 
        : BusinessGeneric<Periodo, PeriodoDto>
    {
        private readonly ILogger<PeriodoService> _logger;
        protected readonly IPeriodoRepository _repository;

        public PeriodoService(
            IPeriodoRepository repository,
            ILogger<PeriodoService> logger,
            IMapper mapper) 
            : base(repository, mapper)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
