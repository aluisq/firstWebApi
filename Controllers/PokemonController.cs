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
using System.Web;
using Microsoft.AspNetCore.Authorization;

namespace firstWebApi.Controllers
{

    [ApiController]
    [Route("/pokemon")]
    public class PokemonController : Controller
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
            
            List<PokemonDB> result = _pokemonService.getAllPokemonsFromDb();

            return result;
        }

         [HttpGet("infoDb/{id}")]
        public string getInfoFromDbById(){
            
            return "peloID";
        
        }


        [HttpGet("teste")]
        [Authorize]
        public async Task<IActionResult> teste(){

            await Task.Delay(2000);

            return Ok("???");
        }

    }

}