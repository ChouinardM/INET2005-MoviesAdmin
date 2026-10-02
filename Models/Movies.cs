namespace MoviesAdmin.Models
{
    public class Movies
    {
        public int Id { get; set; }                 // For each movie
        public string Title { get; set; }           // Toy Story: favourite series
        public string Synopsis { get; set; }        // Description
        public string Genre { get; set; }           // Animated + comedy 
        public string AgeRating { get; set; }       // Age rating
        public int RuntimeMinutes {  get; set; }    // 81 minutes
        public DateTime ReleaseDate { get; set; }   // November 22nd, 1995

    }
}
