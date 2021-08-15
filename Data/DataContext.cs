using firstWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace firstWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<PokemonDB> Pokemons { get; set; }



    }
}