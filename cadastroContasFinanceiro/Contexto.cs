using cadastroContasFinanceiro.Models;
using Microsoft.EntityFrameworkCore;

namespace cadastroContasFinanceiro
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }
        public DbSet<User> User { get; set; }

    }
}
