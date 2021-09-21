using dotnet_tutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_tutorial.Controllers
{

    [ApiController] //attribute
    [Route("[controller]")]//route attribute

    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        //[HttpGet]
        ///[Route("GetAll")]
        public ActionResult<List<Character>> Get() { //IActionResult specific http status code together with results
            return Ok(_characterService.GetAllCharacters());//return NotFound, //BadRequest
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id) {
            return Ok(_characterService.GetCharacterById(id)); //First = error if not found. First or Defual t= null if not found
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}
