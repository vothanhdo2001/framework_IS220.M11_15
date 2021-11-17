using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMusic.Data;
using WebMusic.Models;

namespace WebMusic.Controllers
{
    public class CategoryDetailController : Controller
    {
        private readonly MusicContext _context;

        public CategoryDetailController(MusicContext context)
        {
            _context = context;
        }

        // GET: CategoryDetail
        public async Task<IActionResult> Index()
        {
            var musicContext = _context.CategoryDetailModel.Include(c => c.Category).Include(c => c.Song);
            return View(await musicContext.ToListAsync());
        }

        // GET: CategoryDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryDetailModel = await _context.CategoryDetailModel
                .Include(c => c.Category)
                .Include(c => c.Song)
                .FirstOrDefaultAsync(m => m.MId == id);
            if (categoryDetailModel == null)
            {
                return NotFound();
            }

            return View(categoryDetailModel);
        }

        // GET: CategoryDetail/Create
        public IActionResult Create()
        {
            ViewData["CaId"] = new SelectList(_context.CategoryModel, "CaId", "CaId");
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId");
            return View();
        }

        // POST: CategoryDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CaId,MId")] CategoryDetailModel categoryDetailModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryDetailModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CaId"] = new SelectList(_context.CategoryModel, "CaId", "CaId", categoryDetailModel.CaId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", categoryDetailModel.MId);
            return View(categoryDetailModel);
        }

        // GET: CategoryDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryDetailModel = await _context.CategoryDetailModel.FindAsync(id);
            if (categoryDetailModel == null)
            {
                return NotFound();
            }
            ViewData["CaId"] = new SelectList(_context.CategoryModel, "CaId", "CaId", categoryDetailModel.CaId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", categoryDetailModel.MId);
            return View(categoryDetailModel);
        }

        // POST: CategoryDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CaId,MId")] CategoryDetailModel categoryDetailModel)
        {
            if (id != categoryDetailModel.MId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryDetailModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryDetailModelExists(categoryDetailModel.MId))
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
            ViewData["CaId"] = new SelectList(_context.CategoryModel, "CaId", "CaId", categoryDetailModel.CaId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", categoryDetailModel.MId);
            return View(categoryDetailModel);
        }

        // GET: CategoryDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryDetailModel = await _context.CategoryDetailModel
                .Include(c => c.Category)
                .Include(c => c.Song)
                .FirstOrDefaultAsync(m => m.MId == id);
            if (categoryDetailModel == null)
            {
                return NotFound();
            }

            return View(categoryDetailModel);
        }

        // POST: CategoryDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryDetailModel = await _context.CategoryDetailModel.FindAsync(id);
            _context.CategoryDetailModel.Remove(categoryDetailModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryDetailModelExists(int id)
        {
            return _context.CategoryDetailModel.Any(e => e.MId == id);
        }
    }
}
