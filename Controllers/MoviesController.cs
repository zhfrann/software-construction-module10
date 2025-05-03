using Microsoft.AspNetCore.Mvc;
using modul10_103022330008.Models;

namespace modul10_103022330008.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private static List<Movie> movies = new List<Movie>
    {
        new Movie("The Shawshank Redemption", "Frank Darabont", new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
        new Movie("The Godfather", "Francis Ford Coppola", new List<string> { "Marlon Brando", "Al Pacino", "James Caan" }, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
        new Movie("Interstellar", "Christopher Nolan", new List<string> { "Matthew McConaughey", "Anne Hathaway" }, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.")
    };

    [HttpGet]
    public ActionResult<List<Movie>> GetAll()
    {
        return movies;
    }

    [HttpGet("{id}")]
    public ActionResult<Movie> GetById(int id)
    {
        if (id < 0 || id >= movies.Count)
        {
            return NotFound();
        }
        return movies[id];
    }

    [HttpPost]
    //public ActionResult<Movie> Create(Movie movie)
    //{
    //    movies.Add(movie);
    //    return CreatedAtAction(nameof(GetById), new { id = movies.Count - 1 }, movie);
    //}
    public ActionResult<List<Movie>> Create([FromBody] Movie movie)
    {
        movies.Add(movie);
        return movies;
    }

    [HttpPut("{id}")]
    public ActionResult<List<Movie>> Update(int id,[FromBody] Movie movie)
    {
        if (id < 0 || id >= movies.Count)
        {
            return NotFound();
        }
        movies[id] = movie;
        return movies;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if (id < 0 || id >= movies.Count)
        {
            return NotFound();
        }
        movies.RemoveAt(id);
        return NoContent();
    }
}

