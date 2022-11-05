using Microsoft.EntityFrameworkCore;
using ViagensWebApi.Models;

namespace ViagensWebApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Destino> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destino>().HasData(
                new Destino
                {
                    Id = 1,
                    Nome = "Aveiro",
                    Valor = "4.000,00",
                    Localidade = "Portugual",
                    Proprietario = "Bernardo"
                },

                new Destino
                {
                    Id = 2,
                    Nome = "Porto",
                    Valor = "3.000,00",
                    Localidade = "Portugual",
                    Proprietario = "Maria"
                },

                new Destino
                {
                    Id = 3,
                    Nome = "Leiria",
                    Valor = "2.000,00",
                    Localidade = "Portugual",
                    Proprietario = "Marcos"
                }
                );
        }
    }
}
