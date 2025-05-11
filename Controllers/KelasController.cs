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
    private readonly RestSekolah.Data.SekolahDbContext _context;
    public KelasController(ILogger<KelasController> logger, RestSekolah.Data.SekolahDbContext context)
    {
        _logger = logger;
        _context = context;
    }
   

    [Route("api/kelas/list")]
    public IActionResult Index()
    {
        var kelas = _context.Kelas.ToList();
        return Ok(new
        {
            success = true,
            message = "Data Kelas berhasil diambil",
            data = kelas,
            statusCode = 200
        });
    }

    [Route("api/kelas/edit/{id}")]
    public IActionResult Edit(int id)
    {
        var kelas = _context.Kelas.Find(id);
        if (kelas == null)
        {
            return NotFound(new
            {
                success = false,
                message = "Data Kelas tidak ditemukan",
                statusCode = 404
            });
        }
        return Ok(kelas);
    }
    [HttpPost]
    [Route("/api/kelas/createnew")]
    public IActionResult Create(KelasModel kelas)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors)
                                           .Select(e => e.ErrorMessage)
                                           .ToList();
            return BadRequest(new
            {
                success = false,
                message = "Validasi gagal",
                errors = errors,
                statusCode = 400
            });
        }

        _context.Kelas.Add(kelas);
        _context.SaveChanges();

        return Ok(new
        {
            success = true,
            message = "Data Kelas berhasil disimpan",
            statusCode = 200
        });
    }

    [HttpPost]
    [Route("api/kelas/update/{id}")]
    public IActionResult Update(int id, KelasModel kelas)
    {
        if (id != kelas.Id)
        {
            return BadRequest(new
            {
                success = false,
                message = "ID Kelas tidak sesuai",
                statusCode = 400
            });
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Entry(kelas).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(new
        {
            success = true,
            message = "Data Kelas berhasil diperbarui",
            statusCode = 200
        });
    }
    [HttpPost]
    [Route("api/kelas/delete/{id}")]
    public IActionResult Delete(int id)
    {
        var kelas = _context.Kelas.Find(id);
        if (kelas == null)
        {
            return NotFound(new
            {
                success = false,
                message = "Data Kelas tidak ditemukan",
                statusCode = 404
            });
        }

        _context.Kelas.Remove(kelas);
        _context.SaveChanges();

        return Ok(new
        {
            success = true,
            message = "Data Kelas berhasil dihapus",
            statusCode = 200
        });
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Privacy()
    {
        return View();
    }
     
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Store([Bind("Id,Nama,Kode,JumlahSiswa,Keterangan,Jenis,Kelas,Semester")] KelasModel kelas)
    {
        if (ModelState.IsValid)
        {
            _context.Add(kelas);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(kelas);
    }

}