using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenreController(GenreService genreService) : ControllerBase
{
    // GET: api/<GenreController>
    [HttpGet]
    public ActionResult<IEnumerable<GenreDto>> Get()
    {
        return Ok(genreService.GetAll());
    }

    // GET api/<GenreController>/5
    [HttpGet("{id}")]
    public ActionResult<GenreDto> Get(int id)
    {
        var result = genreService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    // POST api/<GenreController>
    [HttpPost]
    public ActionResult<GenreDto> Post([FromBody] GenreDto value)
    {
        var result = genreService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    // PUT api/<GenreController>/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] GenreDto value)
    {
        var result = genreService.Put(id, value);
        if (!result) 
            return BadRequest();

        return Ok();
    }

    // DELETE api/<GenreController>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = genreService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
