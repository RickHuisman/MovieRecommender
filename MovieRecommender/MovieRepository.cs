using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace MovieRecommender
{
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

        public Movie GetMovieByTitle(List<Movie> movies, string title)
        {
            return movies.Find(movie => movie.Title.Equals(title));
        }
    }
}
