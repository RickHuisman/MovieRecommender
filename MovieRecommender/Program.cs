using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace MovieRecommender
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var movies = GetMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
            }
        }

        private static List<Movie> GetMovies()
        {
            using var streamReader = new StreamReader("/Users/rickhuisman/Downloads/wiki_movie_plots_deduped.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            return csvReader.GetRecords<Movie>().ToList();
        }
    }
}
