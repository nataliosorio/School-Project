using AutoMapper;
using Business.interfaz.metodoGenericos;
using Data.service;
using Entity.Entidades.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Services.ImplementacionGenericos
{
    public class BusinessGeneric<TEntity, TDto> : IBusiness<TDto>
        where TEntity : BaseModel
    {
        private readonly IData<TEntity> _repository;
        private readonly IMapper _mapper;

        public BusinessGeneric(IData<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var created = await _repository.CreateAsync(entity);
            return _mapper.Map<TDto>(created);
        }

        public async Task<bool> UpdateAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            return await _repository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
