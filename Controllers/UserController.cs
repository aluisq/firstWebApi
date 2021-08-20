using System.Threading.Tasks;
using firstWebApi.Models;
using firstWebApi.Services.User;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace firstWebApi.Controllers
{

    [ApiController]
    [Route("/user")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("all")]
        public IActionResult GetUser(){
            
            User user = _userService.GetUser();

            return Ok(user);

        }

    }
}