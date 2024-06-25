using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
  [HttpGet]
  public IActionResult GetAll()
  {
    try
    {
      return Ok();
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }

  [HttpPost]
  public IActionResult Add()
  {
    try
    {
      return Ok();
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }

  [HttpPut("{id}")]
  public IActionResult Update()
  {
    try
    {
      return Ok();
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }

  [HttpDelete("{id}")]
  public IActionResult Delete()
  {
    try
    {
      return Ok();
    }
    catch (Exception ex)
    {
      return BadRequest(new { ex.Message });
    }
  }
}
