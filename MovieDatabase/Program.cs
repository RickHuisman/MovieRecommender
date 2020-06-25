using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MovieDatabase
{
    public class Program
    {
        private static void Main(string[] args)
        {

            AddData();

            return;
            using var context = new MovieContext();
            
            var movie = new Movie()
            {
                IMDbId = "tt0002101",
                Title = "Cleopatra",
            };

            context.Movies.Add(movie);
            context.SaveChanges();
        }

        // Source: https://www.kaggle.com/stefanoleone992/imdb-extensive-dataset
        private static void AddData()
        {
            const string moviePath = "C:/Users/rickh/Desktop/imdb/IMDb movies.csv";

            // Add movies
            using var streamReader = new StreamReader(moviePath);
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            var csvMovies = csvReader.GetRecords<CsvMovie>().ToList();
            var dbMovies = csvMovies.Select(movie =>
            {
                return new Movie
                {
                    IMDbId = movie.IMDbId,
                    Title = movie.Title,
                    Year = movie.Year,
                    Genre = movie.Genre,
                    Duration = movie.Duration,
                    Language = movie.Language,
                    Director = movie.Director,
                    Actors = movie.Actors,
                    Description = movie.Description,
                    AvgVote = movie.AvgVote,
                    Votes = movie.Votes,
                };
            }).ToList();

            Console.WriteLine("Adding");

            using var context = new MovieContext();
            context.Movies.AddRange(dbMovies);
            context.SaveChanges();
            Console.WriteLine("Finished");
        }

        private class CsvMovie
        {
            [Name("imdb_title_id")]
            public string IMDbId { get; set; }
            [Name("title")]
            public string Title { get; set; }
            [Name("year")]
            public int Year { get; set; }
            [Name("genre")]
            public string Genre { get; set; }
            [Name("duration")]
            public int Duration { get; set; }
            [Name("language")]
            public string Language { get; set; }
            [Name("director")]
            public string Director { get; set; }
            [Name("actors")]
            public string Actors { get; set; }
            [Name("description")]
            public string Description { get; set; }
            [Name("avg_vote")]
            public double AvgVote { get; set; }
            [Name("votes")]
            public int Votes { get; set; }
        }
    }
}
