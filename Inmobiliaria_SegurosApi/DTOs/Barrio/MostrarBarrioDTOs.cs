using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Barrio {
    public class MostrarBarrioDTOs {

        public int BarrioID { get; set; }
        public string BarrioName { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;


    }
}
