using Microsoft.AspNetCore.Mvc;
using MediaLibrary.Domain.Repositories;
using MediaLibrary.Domain.Entities;

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorGenreController(ActorGenreRepository repository) : ControllerBase
{
    // GET: api/<ActorGenreController>
    [HttpGet]
    public IEnumerable<ActorGenre> Get()
    {
        return repository.GetAll();
    }

    // GET api/<ActorGenreController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ActorGenreController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ActorGenreController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ActorGenreController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
