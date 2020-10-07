using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FamilyArchive.Data;
using FamilyArchive.Models;

namespace FamilyArchive.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlbumsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Albums
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Album.Include(a => a.Family);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albums = await _context.Album
                .Include(a => a.Family)
                .Include(a => a.Photos)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (albums == null)
            {
                return NotFound();
            }

            return View(albums);
        }

        // GET: Albums/Create
        public IActionResult Create()
        {
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id");
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FamilyId,Pending")] Albums albums)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albums);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", albums.FamilyId);
            return View(albums);
        }

        // GET: Albums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albums = await _context.Album.FindAsync(id);
            if (albums == null)
            {
                return NotFound();
            }
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", albums.FamilyId);
            return View(albums);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FamilyId,Pending")] Albums albums)
        {
            if (id != albums.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(albums);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumsExists(albums.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", albums.FamilyId);
            return View(albums);
        }

        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albums = await _context.Album
                .Include(a => a.Family)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (albums == null)
            {
                return NotFound();
            }

            return View(albums);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var albums = await _context.Album.FindAsync(id);
            _context.Album.Remove(albums);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumsExists(int id)
        {
            return _context.Album.Any(e => e.Id == id);
        }
    }
}
