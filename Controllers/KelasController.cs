namespace RestSekolah.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestSekolah.Data;
using RestSekolah.Models;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;


public class KelasController : Controller
{
    private readonly ILogger<KelasController> _logger;

    public KelasController(ILogger<KelasController> logger)
    {
        _logger = logger;
    }

    [Route("api/kelas/list")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("api/kelas/edit/{id}")]
    public IActionResult Privacy()
    {
        return View();
    }
 
    [HttpPost]
    [Route("api/kelas/create")]
    public IActionResult Create([FromBody] KelasModel kelas)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Simpan data kelas ke database
        // _context.Kelas.Add(kelas);
        // _context.SaveChanges();

        return Ok(new
        {
            success = true,
            message = "Data Kelas berhasil disimpan",
            statusCode = 200
        });
    }
}