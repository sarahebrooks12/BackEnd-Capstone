using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FamilyArchive.Data;
using FamilyArchive.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace FamilyArchive.Controllers
{
    public class PhotosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public PhotosController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Photos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Photo.Include(p => p.Album).Include(p => p.Family);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Photos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photo
                .Include(p => p.Album)
                .Include(p => p.Family)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photos == null)
            {
                return NotFound();
            }

            return View(photos);
        }

        // GET: Photos/Create
        public IActionResult Create()
        {
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id");
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id");
            return View();
        }

        // POST: Photos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ImagePath,MemberId,FamilyId,AlbumId,Pending")] Photos photos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(photos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", photos.AlbumId);
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", photos.FamilyId);
            return View(photos);
        }

        // GET: Photos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photo.FindAsync(id);
            if (photos == null)
            {
                return NotFound();
            }
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", photos.AlbumId);
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", photos.FamilyId);
            return View(photos);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImagePath,MemberId,FamilyId,AlbumId,Pending")] Photos photos)
        {
            if (id != photos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotosExists(photos.Id))
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
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", photos.AlbumId);
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", photos.FamilyId);
            return View(photos);
        }

        // GET: Photos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photo
                .Include(p => p.Album)
                .Include(p => p.Family)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photos == null)
            {
                return NotFound();
            }

            return View(photos);
        }

        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photos = await _context.Photo.FindAsync(id);
            _context.Photo.Remove(photos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotosExists(int id)
        {
            return _context.Photo.Any(e => e.Id == id);
        }
    }
}
