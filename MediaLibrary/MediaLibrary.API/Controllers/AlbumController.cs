using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumController(AlbumService albumService) : ControllerBase
{
    // GET: api/<AlbumController>
    [HttpGet]
    public ActionResult<IEnumerable<AlbumDto>> Get()
    {
        return Ok(albumService.GetAll());
    }

    // GET api/<AlbumController>/5
    [HttpGet("{id}")]
    public ActionResult<AlbumDto> Get(int id)
    {
        var result = albumService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    // POST api/<AlbumController>
    [HttpPost]
    public ActionResult<AlbumDto> Post([FromBody] AlbumDto value)
    {
        var result = albumService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    // PUT api/<AlbumController>/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] AlbumDto value)
    {
        var result = albumService.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    // DELETE api/<AlbumController>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = albumService.Delete(id);
        if (!result)
            return BadRequest();

        return Ok();
    }
}
