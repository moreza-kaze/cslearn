using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test3.Models;

namespace test3.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> Characters = new List<Character> {
            new Character(),
            new Character{
                Id = 2,
                Name = "sina",
                Mmd = RpgClass.kivi
            }
        };

        [HttpGet("")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(Characters);
        }    
        [HttpGet("GetById/{Id}")]
        public ActionResult<List<Character>> GetAmir(int Id)
        {
            return Ok(Characters.FirstOrDefault(character=>  character.Id == Id));
        }  
    }
}