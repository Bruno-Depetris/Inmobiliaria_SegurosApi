using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Common {
    public class PaginationDTOs {
        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; } = 1;

        [Range(1, 100)]
        public int PageSize { get; set; } = 10;

        public string? SearchTerm { get; set; }
        public string? OrderBy { get; set; }
        public bool OrderDescending { get; set; } = false;
    }
}
