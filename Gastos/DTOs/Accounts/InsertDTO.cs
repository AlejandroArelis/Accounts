using Gastos.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Gastos.DTOs.Users;

namespace Gastos.DTOs.Accounts
{
    public class InsertDTO
    {
        [Required(ErrorMessage = "El nombre de la cuenta es obligatoria")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El cantidad de dinero en la cuenta es obligatoria")]
        public decimal Value { get; set; }
        [Required(ErrorMessage = "El usuario de la cuenta es obligatorio")]
        public virtual GetByIdDTO User { get; set; }
    }
}
