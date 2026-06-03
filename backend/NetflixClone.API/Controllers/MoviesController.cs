using Microsoft.AspNetCore.Mvc;

namespace NetflixClone.API.Controllers;

[ApiController]
[Route("movies")]
public class MoviesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMovies()
    {
        return Ok();
    }

    [HttpPost("{id}")]
    public IActionResult getMovieById( Guid id)
    {
        return Ok();
    }
        [HttpPost]
    public IActionResult Create()
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        return Ok();
    }
}
