using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using firstWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using firstWebApi.Services;
using firstWebApi.Data;

namespace firstWebApi.Controllers
{

    [ApiController]
    [Route("/pokemon")]
    public class PokemonController
    {
        private readonly ILogger<PokemonController> _logger;

        private readonly IPokemonService _pokemonService;

        private readonly DataContext _context;
        
        public PokemonController( ILogger<PokemonController> logger, IPokemonService pokemonService, DataContext context )
        {
            _logger = logger;
            _pokemonService = pokemonService;
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<Pokemon> getPkmById(int id){

                Pokemon pkm = await _pokemonService.GetPokemon(id);

                return pkm;
            }

        [HttpGet("infoDb")]
        public List<PokemonDB> getInfoFromDb(){

            var teste = _context.Pokemons.Select(pkm => pkm);
            
            List<PokemonDB> result = _pokemonService.getAllPokemonsFromDb();

            return teste.ToList();
        }

         [HttpGet("infoDb/{id}")]
        public string getInfoFromDbById(){
            
            return "peloID";
        
        }


    }

}