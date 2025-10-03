using Business.Services.ImplementacionGenericos;
using Entity.Entidades.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<TEntity, TDto> : ControllerBase
        where TEntity : BaseModel
    {
        private readonly BusinessGeneric<TEntity, TDto> _service;

        public GenericController(BusinessGeneric<TEntity, TDto> service)
        {
            _service = service;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // GET: api/[controller]/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TDto>> Create(TDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(created);
        }

        // PUT: api/[controller]
        [HttpPut]
        public async Task<IActionResult> Update(TDto dto)
        {
            var updated = await _service.UpdateAsync(dto);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/[controller]/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
