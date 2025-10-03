using AutoMapper;
using Business.Services.ImplementacionGenericos;
using Data.Interfaz;
using Entity.Dtos;
using Microsoft.Extensions.Logging;

namespace Business.Services.Entidades
{
    public class NotaService
        : BusinessGeneric<Nota, NotaDto>
    {
        private readonly ILogger<NotaService> _logger;
        protected readonly INotaRepository _notaRepository;

        public NotaService(
            INotaRepository notaRepository, 
            ILogger<NotaService> logger, 
            IMapper mapper) 
            : base(notaRepository, mapper)
        {
            _notaRepository = notaRepository;
            _logger = logger;
        }   

    }
}
