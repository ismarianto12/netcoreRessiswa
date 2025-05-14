namespace RestSekolah.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSekolah.Models;
using System;
using System.IO;
using System.Linq;


public class SiswaController : ControllerBase
{
    private readonly ILogger<SiswaController> _logger;
    private readonly RestSekolah.Data.SekolahDbContext _context;

    public SiswaController(ILogger<SiswaController> logger, RestSekolah.Data.SekolahDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [Route("api/sekolah/list")]
    [HttpGet]
    public IActionResult Index()
    {
        try
        {
            var siswaList = _context.Siswa.ToList();
            return Ok(siswaList);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Terjadi kesalahan saat mengambil data siswa.");
            return StatusCode(500, new { message = "Terjadi kesalahan pada server", statusCode = 500 });
        }
    }

    [Route("api/sekolah/edit/{id}")]
    [HttpPost]
    public IActionResult Index(int id)
    {
        try
        {
            var siswa = _context.Siswa.Find(id);
            if (siswa == null)
            {
                _logger.LogWarning($"Siswa dengan ID {id} tidak ditemukan.");
                return NotFound(new { message = "Siswa tidak ditemukan", statusCode = 404 });
            }

            return Ok(siswa); // Mengembalikan data dalam format JSON
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Terjadi kesalahan saat mengambil data siswa.");
            return StatusCode(500, new { message = "Terjadi kesalahan pada server", statusCode = 500 });
        }
    }

    [Route("api/sekolah")]
    [HttpGet]
    public IActionResult GeneratePdfWithoutPackage()
    {
        _logger.LogInformation("GeneratePdfWithoutPackage called");
        _logger.LogInformation("GeneratePdfWithoutPackage called");
        try
        {
            var siswaList = _context.Siswa.ToList();

            string htmlContent = "<html><head><title>Laporan Data Siswa</title></head><body>";
            htmlContent += "<h1>Laporan Data Siswa</h1>";
            htmlContent += $"<p>Tanggal: {DateTime.Now:dd MMMM yyyy}</p>";
            htmlContent += "<table border='1' cellpadding='5' cellspacing='0'>";
            htmlContent += "<tr><th>ID</th><th>Nama</th><th>Kelas</th><th>Alamat</th><th>No Telp</th></tr>";

            foreach (var siswa in siswaList)
            {
                htmlContent += $"<tr><td>{siswa.Id}</td><td>{siswa.Nama}</td><td>{siswa.Kelas}</td><td>{siswa.Alamat}</td><td>{siswa.NoTelp}</td></tr>";
            }

            htmlContent += "</table></body></html>";

            byte[] pdfBytes = System.Text.Encoding.UTF8.GetBytes(htmlContent); // Simulasi PDF
            Response.Headers.Add("Content-Disposition", "inline; filename=Laporan-Data-Siswa.pdf");
            return File(pdfBytes, "application/pdf");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Terjadi kesalahan saat membuat PDF.");
            return StatusCode(500, new { message = "Terjadi kesalahan pada server", statusCode = 500 });
        }
    }


}