using Microsoft.AspNetCore.Mvc;
using DamageAPI.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DamageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DamageController(WarriorContext dbContext) : ControllerBase
    {
        private readonly WarriorContext _warriorDbContext = dbContext;

        [HttpPut("{warriorId}/{damage}")]
        public async Task<ActionResult<Warrior>> UpdateWarriorHealth([FromRoute] int warriorId, [FromRoute] int damage)
        {
            var updatedWarrior = await _warriorDbContext.Warriors
                .Where(w => w.Id == warriorId)
                .ExecuteUpdateAsync(setters => setters.SetProperty(w => w.Health, w => w.Health - damage));

            if (updatedWarrior == 0)
            {
                return NotFound($"Warrior with ID {warriorId} not found.");
            }

            return Ok($"Warrior with ID {warriorId} updated");
        }
    }
}
