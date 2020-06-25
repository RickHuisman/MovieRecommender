using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieRecommender
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var recommendations = MovieRecommender.RecommendBasedOf("Dunkirk");
            foreach (var recommendation in recommendations)
            {
                Console.WriteLine(recommendation.Title);
            }
        }

        private static Dictionary<string, int> VectorizeMoviePlot(Movie movie)
        {
            var words = TfidfVectorizer.SplitWords(movie.Plot);
            return TfidfVectorizer.Vectorize(words);
        }
    }
}
