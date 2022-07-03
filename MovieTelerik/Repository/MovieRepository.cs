using MovieTelerik.Data;
using MovieTelerik.Models;

namespace MovieTelerik.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(DataContext context) : base(context)
        {

        }
    }
}
