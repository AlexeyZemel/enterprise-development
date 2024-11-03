using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenreController(GenreRepository repository) : ControllerBase
{
    // GET: api/<GenreController>
    [HttpGet]
    public IEnumerable<Genre> Get()
    {
        return repository.GetAll();
    }

    // GET api/<GenreController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<GenreController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<GenreController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<GenreController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
