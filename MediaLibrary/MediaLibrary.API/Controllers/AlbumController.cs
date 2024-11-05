﻿using MediaLibrary.Domain.Entities;
using MediaLibrary.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaLibrary.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumController(AlbumRepository repository) : ControllerBase
{
    // GET: api/<AlbumController>
    [HttpGet]
    public IEnumerable<Album> Get()
    {
        return repository.GetAll();
    }

    // GET api/<AlbumController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<AlbumController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<AlbumController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<AlbumController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}