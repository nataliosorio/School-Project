using Api.Controllers;
using Business.Services.ImplementacionGenericos;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : GenericController<Estudiante,EstudianteDto>
    {
        public EstudianteController(BusinessGeneric<Estudiante, EstudianteDto> service) : base(service)
        {
        }
    }
}
