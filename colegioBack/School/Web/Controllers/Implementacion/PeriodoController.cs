using Api.Controllers;
using Business.Services.ImplementacionGenericos;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodoController : GenericController<Periodo,PeriodoDto>
    {
        public PeriodoController(BusinessGeneric<Periodo, PeriodoDto> service) : base(service)
        {
        }
    }
}
