using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorController(ActorRepository repository) : ControllerBase
{
    // GET: api/<ActorController>
    [HttpGet]
    public IEnumerable<Actor> Get()
    {
        return repository.GetAll();
    }

    // GET api/<ActorController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ActorController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ActorController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ActorController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
