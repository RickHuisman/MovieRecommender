using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var movies = GetMovies();
            var moviePlotVectorizers = movies.Select(movie => 
            {
                var words = SplitWords(movie.Plot);
                return TfidfVectorizer(words);
            });

            Console.WriteLine(moviePlotVectorizers.Count());
            Console.WriteLine("Done!");
        }

        private static List<Movie> GetMovies()
        {
            using var streamReader = new StreamReader("C:/Users/rickh/Desktop/wiki_movie_plots_deduped.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            return csvReader.GetRecords<Movie>().ToList();
        }

        private static List<string> SplitWords(string words)
        {
            var newWords = words.Split().ToList();

            return newWords;
        }

        private static Dictionary<string, int> TfidfVectorizer(List<string> words)
        {
            Dictionary<string, int> vectorizer = new Dictionary<string, int>();

            foreach (var word in words)
            {
                // Check if word is already added to vectorizer
                if (!vectorizer.ContainsKey(word))
                {
                    vectorizer.Add(word, 1);
                }
                else
                {
                    // += 1
                    vectorizer[word] = vectorizer[word] += 1;
                }
            }

            return vectorizer;
        }
    }
}
