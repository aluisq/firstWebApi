using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using firstWebApi.Models;
using Newtonsoft.Json;
using firstWebApi.Data;
using System.Linq;

namespace firstWebApi.Services
{
    public class PokemonService : IPokemonService
    {
        
        private readonly DataContext _context;

        private readonly string baseUrl = "https://pokeapi.co/api/v2/pokemon/";

        public PokemonService(DataContext context)
        {
            _context = context;
        }

        public List<PokemonDB> getAllPokemonsFromDb()
        {
            IQueryable<PokemonDB> pkms = _context.Pokemons.Select(pkm => pkm);

            return pkms.ToList();
        }

        public async Task<Pokemon> GetPokemon(int id)
        {
             using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage resp = await httpClient.GetAsync(baseUrl + $"{id}");
                    
                    if (resp.IsSuccessStatusCode )
                    {
                    
                    var content = await resp.Content.ReadAsStringAsync();

                    var pkm = JsonConvert.DeserializeObject<Pokemon>(content);

                    return pkm;

                    }else{
                        return new Pokemon();
                    }

                }
                catch (System.Exception)
                {
                    
                    throw;
                }
			}
        }

        public bool PokemonEbom(Pokemon pkm)
        {
            return true;
        }

    }
}