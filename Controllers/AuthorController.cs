using bookstore.Models;
using bookstore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
  private readonly IAuthorRepository _repository;

  public AuthorController(IAuthorRepository repository)
  {
    _repository = repository;
  }

  [HttpGet]
  public IActionResult GetAll()
  {
    try
    {
      return Ok(_repository.GetAll());
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }

  [HttpPost]
  public IActionResult Add([FromBody] Author author)
  {
    try
    {
      return Created("", _repository.Add(author));
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }

  [HttpPut("{id}")]
  public IActionResult Update([FromBody] Author author, int id)
  {
    try
    {
      return Ok(_repository.Update(author, id));
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    try
    {
      _repository.Delete(id);
      return NoContent();
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }
}
