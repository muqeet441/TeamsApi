using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TeamsApi.Models
{
    public class Team
    {

        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
