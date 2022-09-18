using System.ComponentModel.DataAnnotations;

namespace Gastos.DTOs.Users
{
    public class GetByIdDTO
    {
        [Required(ErrorMessage = "El id del usuario es obligatorio")]
        public Guid Id { get; set; } 
    }
}
