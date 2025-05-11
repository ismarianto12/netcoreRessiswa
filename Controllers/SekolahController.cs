using Microsoft.AspNetCore.Mvc;

namespace RestSekolah.Controllers;
//ismarianto allright reserved
public class SekolahController : Controller
{
    private readonly ILogger<SekolahController> _logger;

    public SekolahController(ILogger<SekolahController> logger)
    {
        _logger = logger;
    }

    [Route("api/sekolah/create")]
    [HttpPost]
    public async Task<IActionResult> Index(IFormFile file, string? name, string? address, string? phone)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
        {
            return BadRequest(new
            {
                success = false,
                message = "Name, Address, and Phone are required",
                statusCode = 400
            });
        }
        _logger.LogInformation("Name: " + name);
        _logger.LogInformation("Address: " + address);
        _logger.LogInformation("Phone: " + phone);
        _logger.LogInformation("File: " + file.FileName);
        if (file == null || file.Length == 0)
        {
            return BadRequest("File not selected");
        }

        _logger.LogInformation("File: " + file.FileName);

        if (file == null || file.Length == 0)
        {
            return BadRequest("File not selected");
        }

        var renameFile = file.FileName;
        var fileExtension = Path.GetExtension(renameFile);
        var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(renameFile);
        var newFileName = $"{fileNameWithoutExtension}_{DateTime.Now:yyyyMMddHHmmss}{fileExtension}";
        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", newFileName);

        if (!Directory.Exists(uploadsFolder))
        {
            Directory.Delete(uploadsFolder, true);
            Directory.CreateDirectory(uploadsFolder);
        }
        var filePath = Path.Combine(uploadsFolder, file.FileName);
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return Ok(new { FilePath = filePath });
    }



}
