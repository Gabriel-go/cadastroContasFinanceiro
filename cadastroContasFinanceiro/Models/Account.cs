using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cadastroContasFinanceiro.Models
{
  
    [Table("Account")]
    public class Account
    {
        [Key()]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string description { get; set; }

        public int id_user { get; set; }
        
        public User User { get;  }  


    }
}
