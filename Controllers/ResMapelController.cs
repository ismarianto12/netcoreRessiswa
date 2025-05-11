namespace RestSekolah.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestSekolah.Data;
using RestSekolah.Models;
using System.Linq;

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
    [HttpGet]
    public IActionResult Index(string? search, string? sortBy, string? sortOrder, int page = 1, int pageSize = 10)
    {
        Console.WriteLine(page + "Jumlah Page Size");
        
        if (page < 1) page = 1;
        if (pageSize < 1) pageSize = 10;
        var query = _context.Mapel.AsQueryable();
        // cari 
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(m => EF.Functions.Like(m.Nama, $"%{search}%") || EF.Functions.Like(m.Kode, $"%{search}%"));
        }

        var validSortColumns = new[] { "Nama", "Kode" };
        if (!string.IsNullOrEmpty(sortBy) && validSortColumns.Contains(sortBy))
        {
            if (sortOrder?.ToLower() == "desc")
            {
                query = query.OrderByDescending(e => EF.Property<object>(e, sortBy));
            }
            else
            {
                query = query.OrderBy(e => EF.Property<object>(e, sortBy));
            }
        }

        // Pagination
        var totalItems = query.Count();
        var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
        var items = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        return Ok(new
        {
            success = true,
            data = items,
            pagination = new
            {
                currentPage = page,
                pageSize,
                totalItems,
                totalPages
            }
        });
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