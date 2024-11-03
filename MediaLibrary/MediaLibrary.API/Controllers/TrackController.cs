using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrackController(TrackRepository repository) : ControllerBase
{
    // GET: api/<TrackController>
    [HttpGet]
    public IEnumerable<Track> Get()
    {
        return repository.GetAll();
    }

    // GET api/<TrackController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<TrackController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<TrackController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<TrackController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
