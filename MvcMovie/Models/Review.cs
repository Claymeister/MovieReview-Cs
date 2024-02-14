using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    {

        public int Id { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public int Score { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Timestamp")]
        [DataType(DataType.DateTime)]
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;

        // Foreign keys
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string UserId { get; set; }

        // Navigation properties
        [Required]
        public Movie Movie { get; set; }
        [Required]
        public MvcMovieUser User { get; set; }
    }

}
