using AutoMapper;
using Business.Services.ImplementacionGenericos;
using Data.Interfaz;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.Extensions.Logging;


namespace Business.Services.Entidades
{
    public class SalonService
        : BusinessGeneric<Salon, SalonDto>
    {
        private readonly ILogger<SalonService> _logger;
        protected readonly ISalonRepository _repository;

        public SalonService(
            ISalonRepository repository,
            ILogger<SalonService> logger,
            IMapper mapper) 
            : base(repository, mapper)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}

