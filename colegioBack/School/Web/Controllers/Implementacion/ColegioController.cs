using Api.Controllers;
using Business.Services.ImplementacionGenericos;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColegioController : GenericController<Colegio,ColegioDto>
    {
        public ColegioController(BusinessGeneric<Colegio, ColegioDto> service) : base(service)
        {
        }
    }
}
