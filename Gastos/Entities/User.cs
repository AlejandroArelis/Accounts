using System.ComponentModel.DataAnnotations;

namespace Gastos.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
