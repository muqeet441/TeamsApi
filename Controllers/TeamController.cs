using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TeamsApi.Data;
using TeamsApi.Models;

namespace TeamsApi.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ApiContext _context;

        public TeamController(ApiContext context)
        {
            _context = context;
        }
        [HttpPost]

        public async Task<IActionResult> CreateTeams(int count = 0)
        {
            if (count == 0 && count % 2 != 0)
            {
                return BadRequest("count must be greater than 0 and even");
            }
            var teams = Enumerable.Range(1, count)
            .Select(i => new Team { Name = "Team" + i })
            .ToList(); 

            _context.Teamsname.AddRange(teams);
            await _context.SaveChangesAsync();

            return Ok($"Created {count} teams");
        }
    }
}
