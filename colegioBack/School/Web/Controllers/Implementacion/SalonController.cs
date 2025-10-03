using Api.Controllers;
using Business.Services.ImplementacionGenericos;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonController : GenericController<Salon,SalonDto>
    {
        public SalonController(BusinessGeneric<Salon,SalonDto> service) : base(service)
        {
        }
    }
}
