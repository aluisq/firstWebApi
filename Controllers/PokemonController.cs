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



namespace firstWebApi.Controllers
{

    [ApiController]
    [Route("/pokemon")]

    public class PokemonController
    {
        private readonly ILogger<PokemonController> _logger;

        private readonly IPokemonService _pokemonService;
        
        public PokemonController( ILogger<PokemonController> logger, IPokemonService pokemonService)
        {
            _logger = logger;
            _pokemonService = pokemonService;
        }

        [HttpGet("{id}")]
        public async Task<Pokemon> getPkmById(int id){

                Pokemon pkm = await _pokemonService.GetPokemon(id);

                return pkm;
            }
        }


}