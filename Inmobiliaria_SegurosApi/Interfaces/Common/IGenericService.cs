using Inmobiliaria_SegurosApi.DTOs.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Common {
    public interface IGenericService<TEntity, TCreateDto, TEditDto, TShowDto>
           where TEntity : class
           where TCreateDto : class
           where TEditDto : class
           where TShowDto : class {
        Task<ResponseDTOs<TShowDto>> GetByIdAsync(int id);
        Task<ResponseDTOs<IEnumerable<TShowDto>>> GetAllAsync();
        Task<ResponseDTOs<PagedResultDTOs<TShowDto>>> GetPagedAsync(PaginationDTOs pagination);
        Task<ResponseDTOs<TShowDto>> CreateAsync(TCreateDto createDto);
        Task<ResponseDTOs<TShowDto>> UpdateAsync(TEditDto editDto);
        Task<ResponseDTOs<bool>> DeleteAsync(int id);
        Task<ResponseDTOs<bool>> ExistsAsync(int id);
    }
}
