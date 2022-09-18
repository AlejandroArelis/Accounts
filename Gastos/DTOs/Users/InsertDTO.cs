using System.ComponentModel.DataAnnotations;

namespace Gastos.DTOs.Users
{
    public class InsertDTO
    {
        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        public string Name { get; set; }
    }
}
