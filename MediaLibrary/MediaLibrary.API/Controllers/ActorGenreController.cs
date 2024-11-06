using Microsoft.AspNetCore.Mvc;
using MediaLibrary.Domain.Entities;
using MediaLibrary.API.Services;

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorGenreController(ActorGenreService actorGenreService) : ControllerBase
{
    // GET: api/<ActorGenreController>
    [HttpGet]
    public ActionResult<IEnumerable<ActorGenre>> Get()
    {
        return Ok(actorGenreService.GetAll());
    }

    // GET api/<ActorGenreController>/5
    [HttpGet("{id}")]
    public ActionResult<ActorGenre> Get(int id)
    {
        var result = actorGenreService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    // POST api/<ActorGenreController>
    [HttpPost]
    public ActionResult<ActorGenre> Post([FromBody] ActorGenre value)
    {
        var result = actorGenreService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    // PUT api/<ActorGenreController>/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] ActorGenre value)
    {
        var result = actorGenreService.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    // DELETE api/<ActorGenreController>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = actorGenreService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
