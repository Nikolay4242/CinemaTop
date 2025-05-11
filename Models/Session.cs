// Models/Session.cs
namespace CinemaProject.Models
{
    public class Session
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string MovieTitle { get; set; }
        public decimal Price { get; set; }
    }
}
