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
    public class AlbumDetailController : Controller
    {
        private readonly MusicContext _context;

        public AlbumDetailController(MusicContext context)
        {
            _context = context;
        }

        // GET: AlbumDetail
        public async Task<IActionResult> Index()
        {
            var musicContext = _context.AlbumDetailModel.Include(a => a.Album);
            return View(await musicContext.ToListAsync());
        }

        // GET: AlbumDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumDetailModel = await _context.AlbumDetailModel
                .Include(a => a.Album)
                .FirstOrDefaultAsync(m => m.AId == id);
            if (albumDetailModel == null)
            {
                return NotFound();
            }

            return View(albumDetailModel);
        }

        // GET: AlbumDetail/Create
        public IActionResult Create()
        {
            ViewData["SiId"] = new SelectList(_context.AlbumModel, "AId", "AId");
            return View();
        }

        // POST: AlbumDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AId,MId,UsId,SiId")] AlbumDetailModel albumDetailModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albumDetailModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SiId"] = new SelectList(_context.AlbumModel, "AId", "AId", albumDetailModel.SiId);
            return View(albumDetailModel);
        }

        // GET: AlbumDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumDetailModel = await _context.AlbumDetailModel.FindAsync(id);
            if (albumDetailModel == null)
            {
                return NotFound();
            }
            ViewData["SiId"] = new SelectList(_context.AlbumModel, "AId", "AId", albumDetailModel.SiId);
            return View(albumDetailModel);
        }

        // POST: AlbumDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AId,MId,UsId,SiId")] AlbumDetailModel albumDetailModel)
        {
            if (id != albumDetailModel.AId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(albumDetailModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumDetailModelExists(albumDetailModel.AId))
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
            ViewData["SiId"] = new SelectList(_context.AlbumModel, "AId", "AId", albumDetailModel.SiId);
            return View(albumDetailModel);
        }

        // GET: AlbumDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumDetailModel = await _context.AlbumDetailModel
                .Include(a => a.Album)
                .FirstOrDefaultAsync(m => m.AId == id);
            if (albumDetailModel == null)
            {
                return NotFound();
            }

            return View(albumDetailModel);
        }

        // POST: AlbumDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var albumDetailModel = await _context.AlbumDetailModel.FindAsync(id);
            _context.AlbumDetailModel.Remove(albumDetailModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumDetailModelExists(int id)
        {
            return _context.AlbumDetailModel.Any(e => e.AId == id);
        }
    }
}
