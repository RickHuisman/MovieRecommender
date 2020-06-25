using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MovieRecommender
{
    // TODO Convert to singleton
    public class MovieRepository
    {
        private List<Movie> Movies { get; }

        public MovieRepository(string path)
        {
            using var streamReader = new StreamReader(path);
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            Movies = csvReader.GetRecords<Movie>().ToList();
        }

        public List<Movie> GetMovies()
        {
            return Movies;
        }

        public Movie GetMovieByTitle(string title)
        {
            return Movies.Find(movie => movie.Title.Equals(title));
        }

        public Movie GetRandomMovie()
        {
            var rand = new Random();

            return Movies[rand.Next(Movies.Count())];
        }
    }
}
