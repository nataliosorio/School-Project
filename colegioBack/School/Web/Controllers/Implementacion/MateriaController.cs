using Api.Controllers;
using Business.Services.ImplementacionGenericos;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : GenericController<Materia,MateriaDto>
    {
        public MateriaController(BusinessGeneric<Materia, MateriaDto> service) : base(service)
        {
        }
    }
}
