using System.Net.Http;
using System.Threading.Tasks;
using firstWebApi.Models;
using Newtonsoft.Json;

namespace firstWebApi.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly string baseUrl = "https://pokeapi.co/api/v2/pokemon/";
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