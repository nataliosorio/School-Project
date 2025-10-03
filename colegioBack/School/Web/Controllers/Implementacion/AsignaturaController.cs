using Api.Controllers;
using Business.interfaz.Entidades;
using Business.Services.ImplementacionGenericos;
using Entity.Dtos;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Controllers.Implementacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturaController : GenericController<Asignatura, AsignaturaDto>
    {

        public AsignaturaController(BusinessGeneric<Asignatura,AsignaturaDto> service)
            : base(service)
        {
        }
    }
}
