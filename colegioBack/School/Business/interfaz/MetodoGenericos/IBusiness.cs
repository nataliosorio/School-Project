using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.interfaz.metodoGenericos
{
    public interface IBusiness<TDto>
    {
        Task<TDto?> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> CreateAsync(TDto dto);
        Task<bool> UpdateAsync(TDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
