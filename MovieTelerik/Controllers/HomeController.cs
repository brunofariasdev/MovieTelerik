﻿using Microsoft.AspNetCore.Mvc;
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
            PopulateGenres();
            var data = new MovieAndGenre();
            data.Movies = GetAllMovies();
            data.GenreCount = GetAllGenres().Count();
            data.Genres = GetAllGenres();
            data.DefaultGenre = data.Genres.First();
            ViewData["Error"] = "Error";
            return View(data);
        }


        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = _movie.GetAll();

            return movies;
        }

        public IActionResult CreateMovie(Movie movie)
        {
            ViewData["Error"] = "Error2";
            if (movie != null)
                {
                var idGenre = 0;
                    if (movie.Genre != null)
                    {
                        idGenre = movie.Genre.Id;
                    }
                    Movie data = new Movie
                    {
                        Title = movie.Title,
                        Resume = movie.Resume,
                        UrlImg = movie.UrlImg,
                        MetaScore = movie.MetaScore,
                        CreatedDate = new DateTime(),
                        GenreId = idGenre,
                        Genre = null
                    };
                    try
                    {
                        _movie.Create(data);
                        throw new ArgumentException("Error ao adicionar Movie");
                    }
                    catch
                    {
                        TempData["erro"] = "Descrição do erro";
                    }
            }
         
            
            return RedirectToAction(nameof(Index));
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

        public void PopulateGenres()
        {
            var genres = GetAllGenres();
            ViewData["AllGenres"] = genres;
            ViewData["DefaultGenre"] = GetAllGenres().First();
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
