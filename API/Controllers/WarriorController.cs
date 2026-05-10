using Microsoft.AspNetCore.Mvc;
using DamageAPI.Data;
using Models;
using Microsoft.EntityFrameworkCore;

namespace DamageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarriorController(WarriorContext dbContext) : ControllerBase
    {
        private readonly WarriorContext _warriorDbContext = dbContext;

        [HttpPost("add")]
        public async Task<ActionResult<Warrior>> CreateWarrior([FromBody] Warrior warrior)
        {
            if (warrior.Name is null)
            {
                return BadRequest("Warrior name cannot be null");
            }
            if (warrior.Health == 0)
            {
                return BadRequest("Warrior health cannot be 0");
            }

            _warriorDbContext.Warriors.Add(warrior);
            await _warriorDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWarrior), new { id = warrior.Id }, warrior);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Warrior>> GetWarrior([FromRoute] int id)
        {
            var warrior = await _warriorDbContext.Warriors.FindAsync(id);
            if (warrior is null)
            {
                return StatusCode(StatusCodes.Status404NotFound, $"Warrior with ID {id} not found.");
            }

            return warrior;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteWarrior([FromRoute] int id)
        {
            var warrior = await _warriorDbContext.Warriors.FindAsync(id);
            if(warrior is null)
            {
                return StatusCode(StatusCodes.Status404NotFound, $"Warrior with ID {id} not found.");
            }

            await _warriorDbContext.Warriors.Where(w => w.Id == id).ExecuteDeleteAsync();

            return Ok($"Warrior with ID: {id} deleted.");
        }
    }
}
