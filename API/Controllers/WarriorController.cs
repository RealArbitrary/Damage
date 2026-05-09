using Microsoft.AspNetCore.Mvc;
using DamageAPI.Data;
using Models;

namespace DamageAPI.Controllers
{
    [ApiController]
    public class WarriorController(WarriorDbContext dbContext) : ControllerBase
    {
        private readonly WarriorDbContext _warriorDbContext = dbContext;

        [HttpGet("{id}")]
        public async Task<ActionResult<Warrior>> WarriorDetails([FromRoute] int id)
        {
            var warrior = await _warriorDbContext.Warriors.FindAsync(id);
            if (warrior is null)
            {
                return StatusCode(StatusCodes.Status404NotFound, $"Warrior with ID {id} not found.");
            }

            return warrior;
        }
    }
}
