using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/recommended")]
    [ApiController]
    public class MovieRecommenderController : ControllerBase
    {
        [HttpGet("random")]
        public IActionResult GetRandomMovie()
        {
            var movie = MovieRecommender.MovieRecommender.RecommendRandomMovie();
            return Ok(movie);
        }

        [HttpGet("basedon")]
        public IActionResult GetRecommendedMoviesBasedOnMovie()
        {
            // TODO
            return Ok();
        }

        [HttpGet("genre")]
        public IActionResult GetRecommendedMoviesByGenre()
        {
            // TODO
            return Ok();
        }

        [HttpGet("actor")]
        public IActionResult GetRecommendedMoviesByActor()
        {
            // TODO
            return Ok();
        }

        [HttpGet("director")]
        public IActionResult GetRecommendedMoviesByDirector()
        {
            // TODO
            return Ok();
        }
    }
}
