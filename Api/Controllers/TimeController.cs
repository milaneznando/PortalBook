using Microsoft.AspNetCore.Mvc;

namespace PortalBook.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TimeController : ControllerBase
{
    
    /// <summary>
    /// Returns the current datetime
    /// </summary>
    /// <returns>Returns the current datetime</returns>
    [HttpGet("showTime")]
    public IActionResult Get()
    {
        try
        { 
            return Ok(DateTime.UtcNow.ToString("o"));
        }
        catch (Exception ex)
        {
            return BadRequest(new Exception(ex.Message));
        }
    }
}