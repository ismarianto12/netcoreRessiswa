namespace SiswaRest.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RestSekolah.Models;

public class SiswaController : Controller
{
    private readonly ILogger<SiswaController> _logger;
    private readonly RestSekolah.Data.SekolahDbContext _context;

    public SiswaController(ILogger<SiswaController> logger, RestSekolah.Data.SekolahDbContext context)
    {
        _logger = logger;
        _context = context;
    }


    // GET: Siswa
    public IActionResult Index()
    {
        var siswa = _context.Siswa.ToList();
        return Ok(siswa);
    }

    // GET: Siswa/Details/5
    public IActionResult Details(int id)
    {

        var siswa = _context.Siswa.Find(id);
        return Ok(siswa);


    }

    // GET: Siswa/Create
    public IActionResult Create()
    {
        return View();
    }


    [HttpPost]
    [Route("api/siswa")]
    public IActionResult Create([FromBody] SiswaModel siswa)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Siswa.Add(siswa);
        _context.SaveChanges();

        return CreatedAtAction(nameof(Details), new { id = siswa.Id }, siswa);
    }

    // GET: Siswa/Edit/5
    public IActionResult Edit(int id)
    {
        return View();
    }
    // POST: Siswa/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, [Bind("Id,Nama,Kelas,Alamat,NoTelp")] SiswaModel siswa)
    {

        if (ModelState.IsValid)
        {
            // 
        }
        return View(siswa);
    }
    public IActionResult Delete(int id)
    {
        return View();
    }
    // POST: Siswa/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        // Hapus data siswa dari database
        return RedirectToAction(nameof(Index));
    }

    // GET: Siswa/Search
    public IActionResult Search(string query)
    {
        // Lakukan pencarian siswa berdasarkan query
        return View();
    }
    // POST: Siswa/Search
    [HttpPost]
    [ValidateAntiForgeryToken]

    // GET: Siswa/Export        
    public IActionResult Export()
    {
        // Ekspor data siswa ke format yang diinginkan (misalnya CSV, Excel, dll.)
        return View();
    }
    // POST: Siswa/Import
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Import(IFormFile file)
    {
        if (file != null && file.Length > 0)
        {
            // Proses file untuk mengimpor data siswa
            return RedirectToAction(nameof(Index));
        }
        return View();
    }
    // GET: Siswa/Print
    public IActionResult Print()
    {
        // Cetak data siswa
        return View();
    }
    // POST: Siswa/Print
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Print([Bind("Id,Nama,Kelas,Alamat,NoTelp")] SiswaModel siswa)
    {
        if (ModelState.IsValid)
        {
            // Cetak data siswa
            return RedirectToAction(nameof(Index));
        }
        return View(siswa);
    }

}