using MovieTelerik.Data;
using MovieTelerik.Models;

namespace MovieTelerik.Repository
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(DataContext context) : base(context)
        {
        }
    }
}
