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
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;

public class ResMapelController : Controller
{
    private readonly ILogger<ResMapelController> _logger;
    private readonly RestSekolah.Data.SekolahDbContext _context;


    public ResMapelController(ILogger<ResMapelController> logger, RestSekolah.Data.SekolahDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    // GET: Mapel
    [Route("api/mapel/list")]
    public IActionResult Index()
    {
        var mapel = _context.Mapel.ToList();
        return Ok(mapel);
    }
    // GET: Mapel/Details/5
    [Route("api/mapel/details/{id}")]
    [HttpGet]
    public IActionResult Details(int id)
    {
        var mapel = _context.Mapel.Find(id);
        if (mapel == null)
        {
            return NotFound(new
            {
                success = false,
                message = "Data Mapel tidak ditemukan",
                statusCode = 404
            });
        }
        return Ok(mapel);
    }
    // GET: Mapel/Create
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [Route("api/mapel/create")]
    public IActionResult Create([FromBody] MapelModel mapel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Mapel.Add(mapel);
        _context.SaveChanges();

        return CreatedAtAction(nameof(Details), new { id = mapel.Id }, mapel);
    }
    // GET: Mapel/Edit/5
    public IActionResult Edit(int id)
    {
        var mapel = _context.Mapel.Find(id);
        if (mapel == null)
        {
            return NotFound();
        }
        return View(mapel);
    }
    // POST: Mapel/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, [Bind("Id,Nama,Kode,JumlahSiswa,Keterangan,Jenis,Kelas,Semester")] MapelModel mapel)
    {
        if (id != mapel.Id)
        {
            return NotFound();
        }
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            _context.Update(mapel);
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {

        }
        return RedirectToAction(nameof(Index));
    }
    // GET: Mapel/Delete/5
    public IActionResult Delete(int id)
    {
        var mapel = _context.Mapel.Find(id);
        if (mapel == null)
        {
            return NotFound();
        }
        return View(mapel);
    }
}