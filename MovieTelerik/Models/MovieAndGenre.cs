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

    }
}
