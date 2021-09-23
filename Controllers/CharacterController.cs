using dotnet_tutorial.Dtos.Character;
using dotnet_tutorial.Models;
using dotnet_tutorial.Services;
using dotnet_tutorial.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get() { //IActionResult specific http status code together with results
            return Ok(await _characterService.GetAllCharacters());//return NotFound, //BadRequest
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id) {
            return Ok(await _characterService.GetCharacterById(id)); //First = error if not found. First or Defual t= null if not found
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter){
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var res = await _characterService.UpdateCharacter(updatedCharacter);
            if (res.Data == null)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
        {
            var res = await _characterService.DeleteCharacter(id);
            if (res.Data == null)
            {
                return NotFound(res);
            }
            return Ok(res);
        }


    }
}
