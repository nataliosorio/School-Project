using Api.Controllers;
using Business.Services.ImplementacionGenericos;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : GenericController<Asignatura,AsignaturaDto>
    {
        public NotaController(BusinessGeneric<Asignatura,AsignaturaDto> service) : base(service)
        {
        }
    }
}
