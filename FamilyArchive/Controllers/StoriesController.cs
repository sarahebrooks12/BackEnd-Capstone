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
    public class StoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stories
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Story.Include(s => s.Family);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Stories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stories = await _context.Story
                .Include(s => s.Family)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stories == null)
            {
                return NotFound();
            }

            return View(stories);
        }

        // GET: Stories/Create
        public IActionResult Create()
        {
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id");
            return View();
        }

        // POST: Stories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,MemberId,FamilyId,Pending")] Stories stories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", stories.FamilyId);
            return View(stories);
        }

        // GET: Stories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stories = await _context.Story.FindAsync(id);
            if (stories == null)
            {
                return NotFound();
            }
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", stories.FamilyId);
            return View(stories);
        }

        // POST: Stories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,MemberId,FamilyId,Pending")] Stories stories)
        {
            if (id != stories.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoriesExists(stories.Id))
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
            ViewData["FamilyId"] = new SelectList(_context.Family, "Id", "Id", stories.FamilyId);
            return View(stories);
        }

        // GET: Stories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stories = await _context.Story
                .Include(s => s.Family)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stories == null)
            {
                return NotFound();
            }

            return View(stories);
        }

        // POST: Stories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stories = await _context.Story.FindAsync(id);
            _context.Story.Remove(stories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoriesExists(int id)
        {
            return _context.Story.Any(e => e.Id == id);
        }
    }
}
