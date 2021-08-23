using firstWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace firstWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<User> Users { get; set; }

        public DbSet<PokemonDB> Pokemons { get; set; }



        // Tornando os campos unique
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<User>(entity => {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(e => e.Id).IsUnique();
                entity.HasIndex(e => e.Login).IsUnique();
            });
        }
        
    }
}