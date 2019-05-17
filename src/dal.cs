using cadcliapi;
using Microsoft.EntityFrameworkCore;

namespace cadcli {
    public class dal : DbContext {

        public dal()
        {
            Database.EnsureCreated();
        }

        public DbSet<cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("string de conexão");

        }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cliente>().HasData(
                new cliente{Id = 1, Nome = "Fabiano", Idade = 39},
                new cliente{Id = 2, Nome = "Priscila", Idade = 40}
            );

        }
        
    }
}