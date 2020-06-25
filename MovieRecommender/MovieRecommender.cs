using System.Collections.Generic;

namespace MovieRecommender
{
    public class MovieRecommender
    {
        public static List<Movie> RecommendBasedOf(string movieTitle)
        {
            var path = "C:/Users/rickh/Desktop/wiki_movie_plots_deduped.csv";
            var movieRepository = new MovieRepository(path);

            var movie = movieRepository.GetMovieByTitle(movieTitle);

            return new List<Movie>
            {
                movieRepository.GetRandomMovie(),
                movieRepository.GetRandomMovie(),
                movieRepository.GetRandomMovie(),
            };
        }

        public static Movie RecommendRandomMovie()
        {
            var path = "C:/Users/rickh/Desktop/wiki_movie_plots_deduped.csv";
            var movieRepository = new MovieRepository(path);

            return movieRepository.GetRandomMovie();
        }
    }
}
