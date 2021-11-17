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
    public class SongDetailController : Controller
    {
        private readonly MusicContext _context;

        public SongDetailController(MusicContext context)
        {
            _context = context;
        }

        // GET: SongDetail
        public async Task<IActionResult> Index()
        {
            var musicContext = _context.SongDetailModel.Include(s => s.Singer).Include(s => s.Song);
            return View(await musicContext.ToListAsync());
        }

        // GET: SongDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songDetailModel = await _context.SongDetailModel
                .Include(s => s.Singer)
                .Include(s => s.Song)
                .FirstOrDefaultAsync(m => m.SiId == id);
            if (songDetailModel == null)
            {
                return NotFound();
            }

            return View(songDetailModel);
        }

        // GET: SongDetail/Create
        public IActionResult Create()
        {
            ViewData["SiId"] = new SelectList(_context.SingerModel, "SiId", "SiId");
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId");
            return View();
        }

        // POST: SongDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SiId,MId")] SongDetailModel songDetailModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(songDetailModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SiId"] = new SelectList(_context.SingerModel, "SiId", "SiId", songDetailModel.SiId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", songDetailModel.MId);
            return View(songDetailModel);
        }

        // GET: SongDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songDetailModel = await _context.SongDetailModel.FindAsync(id);
            if (songDetailModel == null)
            {
                return NotFound();
            }
            ViewData["SiId"] = new SelectList(_context.SingerModel, "SiId", "SiId", songDetailModel.SiId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", songDetailModel.MId);
            return View(songDetailModel);
        }

        // POST: SongDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SiId,MId")] SongDetailModel songDetailModel)
        {
            if (id != songDetailModel.SiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(songDetailModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongDetailModelExists(songDetailModel.SiId))
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
            ViewData["SiId"] = new SelectList(_context.SingerModel, "SiId", "SiId", songDetailModel.SiId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", songDetailModel.MId);
            return View(songDetailModel);
        }

        // GET: SongDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songDetailModel = await _context.SongDetailModel
                .Include(s => s.Singer)
                .Include(s => s.Song)
                .FirstOrDefaultAsync(m => m.SiId == id);
            if (songDetailModel == null)
            {
                return NotFound();
            }

            return View(songDetailModel);
        }

        // POST: SongDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var songDetailModel = await _context.SongDetailModel.FindAsync(id);
            _context.SongDetailModel.Remove(songDetailModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongDetailModelExists(int id)
        {
            return _context.SongDetailModel.Any(e => e.SiId == id);
        }
    }
}
