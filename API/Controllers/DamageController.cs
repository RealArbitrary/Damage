using Microsoft.AspNetCore.Mvc;
using DamageAPI.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DamageAPI.Controllers
{
    [ApiController]
    public class DamageController(WarriorDbContext dbContext) : ControllerBase
    {
        private readonly WarriorDbContext _warriorDbContext = dbContext;

        [HttpPut("{warriorId}/{damage}")]
        public async Task<ActionResult<Warrior>> DoDamageToWarrior([FromRoute] int warriorId, [FromRoute] int damage)
        {
            var updateWarrior = await _warriorDbContext.Warriors
                .Where(w => w.Id == warriorId)
                .ExecuteUpdateAsync(setters => setters.SetProperty(w => w.Health, w => w.Health - damage));

            if (updateWarrior == 0)
            {
                return NotFound($"Warrior with ID {warriorId} not found.");
            }

            var updatedWarrior = await _warriorDbContext.Warriors.FindAsync(warriorId);

            return Ok(updatedWarrior);

        }
    }
}
