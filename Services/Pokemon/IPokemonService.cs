using System.Collections.Generic;
using System.Threading.Tasks;
using firstWebApi.Models;

namespace firstWebApi.Services
{
    public interface IPokemonService
    {
        Task<Pokemon> GetPokemon(int id);
        bool PokemonEbom(Pokemon pkm);
        List<PokemonDB> getAllPokemonsFromDb();
         
    }
}