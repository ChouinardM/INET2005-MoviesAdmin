using System.ComponentModel.DataAnnotations;

namespace MoviesAdmin.Models
{
    public class Movies
    {
        public int Id { get; set; }                 // For each movie

        [Required]
        [StringLength(100)]
        public string Title { get; set; }           // Toy Story: favourite series

        [Required]
        [StringLength(1000)]
        public string Synopsis { get; set; }        // Description

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }           // Animated + comedy 

        [Required]
        [StringLength(10)]
        public string AgeRating { get; set; }       // Age rating

        [Range(1, 500)]
        public int RuntimeMinutes {  get; set; }    // 81 minutes

        [Range(1900, 2100)]
        public DateTime ReleaseDate { get; set; }   // November 22nd, 1995

    }
}
