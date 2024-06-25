using bookstore.Models;
using bookstore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
  private readonly IBookRepository _repository;

  public BookController(IBookRepository repository)
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
  public IActionResult Add([FromBody] Book book)
  {
    try
    {
      return Created("", _repository.Add(book));
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }

  [HttpPut("{id}")]
  public IActionResult Update([FromBody] Book book, int id)
  {
    try
    {
      return Ok(_repository.Update(book, id));
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
