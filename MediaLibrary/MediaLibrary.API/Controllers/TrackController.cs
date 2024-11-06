using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrackController(TrackService trackService) : ControllerBase
{
    // GET: api/<TrackController>
    [HttpGet]
    public ActionResult<IEnumerable<TrackDto>> Get()
    {
        return Ok(trackService.GetAll());
    }

    // GET api/<TrackController>/5
    [HttpGet("{id}")]
    public ActionResult<TrackDto> Get(int id)
    {
        var result = trackService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    // POST api/<TrackController>
    [HttpPost]
    public ActionResult<TrackDto> Post([FromBody] TrackDto value)
    {
        var result = trackService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    // PUT api/<TrackController>/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] TrackDto value)
    {
        var result = trackService.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    // DELETE api/<TrackController>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = trackService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
