using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Gastos.Entities
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "El nombre de la cuenta es obligatoria")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El cantidad de dinero en la cuenta es obligatoria")]
        [DefaultValue (0)]
        public decimal Value { get; set; }
        [Required(ErrorMessage = "El propietario (usuario) de la cuenta es obligatorio")]
        [ForeignKey("user")]
        public User User { get; set; }
    }
}
