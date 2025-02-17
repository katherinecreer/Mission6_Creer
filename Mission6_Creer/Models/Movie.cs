using System.ComponentModel.DataAnnotations;

namespace Mission6_Creer.Models
{
    public class Movie
    {
        [Key] // Primary Key
        public int MovieId { get; set; }

        [Required] public string Title { get; set; } = string.Empty;

        [Required] public string Category { get; set; } = string.Empty;

        [Required] public int Year { get; set; }

        [Required] public string Director { get; set; } = string.Empty;

        [Required] public string Rating { get; set; } = string.Empty; // Dropdown (G, PG, PG-13, R)

        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25)] // Limit to 25 characters
        public string? Notes { get; set; }
    }
}

