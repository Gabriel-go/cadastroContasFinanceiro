using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cadastroContasFinanceiro.Models
{
    [Table("User")]
    public class User
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Email { get; set; }
        public string Password { get; set; }

        //public List<Account> Accounts { get; }
    }
}
