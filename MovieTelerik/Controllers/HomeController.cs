using Microsoft.AspNetCore.Mvc;
using MovieTelerik.Models;
using MovieTelerik.Repository;
using System.Diagnostics;

namespace MovieTelerik.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movie;
        private readonly IGenreRepository _genre;

        public HomeController(IMovieRepository movie, IGenreRepository genre)
        {
            _movie = movie;
            _genre = genre;
        }

        public IActionResult Index()
        {
            var data = new MovieAndGenre();
            data.Movies = GetAllMovies();
            data.GenreCount = GetAllGenres().Count();
            return View(data);
        }


        public IEnumerable<Movie> GetAllMovies()
        {
            var x = _movie.GetAll();

            return x;
        }

        public void CreateMovie(Movie movie)
        {
            if (movie != null)
            {
                _movie.Create(movie);
            }
        }

        public void UpdateMovie(Movie movie)
        {
            if(movie != null)
            {
                
                _movie.Update(movie);
            }
        }

        public void DeleteMovie(Movie movie)
        {
            _movie.Delete(movie.Id);
        }


        public IEnumerable<Genre> GetAllGenres()
        {
            return _genre.GetAll();
        }


        public IActionResult CreateGenre(Genre genre)
        {
            if(genre != null)
            {
                _genre.Create(genre);
            }
            return RedirectToAction(nameof(Index));
            
        }

        public void UpdateGenre(Genre genre)
        {
            if(genre != null)
            {
                _genre.Update(genre);
            }
        }

        public void DeleteGenre(Genre genre)
        {
            if(genre != null)
            {
                _genre.Delete(genre.Id);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
