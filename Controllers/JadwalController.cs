namespace RestSekolah.Controllers;

using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class JadwalController : ControllerBase
{

    private readonly ILogger<JadwalController> _logger;
    private readonly RestSekolah.Data.SekolahDbContext _context;
    public JadwalController(ILogger<JadwalController> logger, RestSekolah.Data.SekolahDbContext context)
    {
        _logger = logger;
        _context = context;
    }


    [HttpGet]
    public IActionResult Get()
    { 
        _logger.LogInformation("Get method called");
        var data = _context.Jadwal.ToList();
        if (data == null || data.Count == 0)
        {
            return NotFound(new { message = "Data not found" });
        }
        return Ok(new { message = "ok" });
    }

    [HttpPost]
    public IActionResult Post()
    {
        return Ok(new { message = "ok" });
    }

    [HttpPut]
    public IActionResult Put()
    {
        return Ok(new { message = "ok" });
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok(new { message = "ok" });
    }
}
