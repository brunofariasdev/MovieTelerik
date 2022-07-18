using System.ComponentModel.DataAnnotations;

namespace MovieTelerik.Models
{
    public class MovieAndGenre
    {
#pragma warning disable CS8618
        public MovieAndGenre()
#pragma warning restore CS8618 
        {
            var movie = new Movie();
        }
        public IEnumerable<Movie> Movies { get; set; }
        public int GenreCount { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        
        public Genre DefaultGenre { get; internal set; }
    }
}
