// Models/Movie.cs
namespace CinemaProject.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public List<Session> Sessions { get; set; }
    }
}
