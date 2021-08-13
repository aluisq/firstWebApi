using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using firstWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;

namespace firstWebApi.Controllers
{

    [ApiController]
    [Route("/pokemon")]
    public class PokemonController
    {
        private readonly string baseUrl = "https://pokeapi.co/api/v2/pokemon/";
        private readonly ILogger<PokemonController> _logger;
        public PokemonController(ILogger<PokemonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<Pokemon> getPkmById(string id){

            
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


        [HttpGet("/moves")]
        public string doSomething(){
            return "moves!";
        }
    

    }

    

}