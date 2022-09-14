using cadastroContasFinanceiro.Models;
using Microsoft.EntityFrameworkCore;

namespace cadastroContasFinanceiro
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }
        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .HasOne(p => p.User)
            .WithMany(b => b.Accounts);
            //.HasForeignKey(p => p.id_user);
            //.HasPrincipalKey(b => b.Id);
        }
    }
}
