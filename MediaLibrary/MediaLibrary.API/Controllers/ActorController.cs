using MediaLibrary.API.Dto;
using MediaLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorController(ActorService actorService) : ControllerBase
{
    // GET: api/<ActorController>
    [HttpGet]
    public ActionResult<IEnumerable<ActorDto>> Get()
    {
        return Ok(actorService.GetAll());
    }

    // GET api/<ActorController>/5
    [HttpGet("{id}")]
    public ActionResult<ActorDto> Get(int id)
    {
        var result = actorService.GetById(id);
        if (result == null) 
            return NotFound();

        return Ok(result);
    }

    // POST api/<ActorController>
    [HttpPost]
    public ActionResult<ActorDto> Post([FromBody] ActorDto value)
    {
        var result = actorService.Post(value);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    // PUT api/<ActorController>/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] ActorDto value)
    {
        var result = actorService.Put(id, value);
        if (!result)
            return BadRequest();

        return Ok();
    }

    // DELETE api/<ActorController>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var result = actorService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
