using Microsoft.EntityFrameworkCore;
using TeamsApi.Models;

namespace TeamsApi.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions option) : base(option) { }
        public DbSet<Team> Teamsname { get; set; }
    }

}
