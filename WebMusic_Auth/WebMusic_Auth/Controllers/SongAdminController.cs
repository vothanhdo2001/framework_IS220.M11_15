using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMusic_Auth.Data;
using WebMusic_Auth.Models;

namespace WebMusic_Auth.Controllers
{
    public class SongAdminController : Controller
    {
        private readonly MusicContext _context;

        public SongAdminController(MusicContext context)
        {
            _context = context;
        }

        // GET: SongAdmin
        public async Task<IActionResult> Index()
        {
            return View(await _context.SongModel.ToListAsync());
        }

        // GET: SongAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songModel = await _context.SongModel
                .FirstOrDefaultAsync(m => m.MId == id);
            if (songModel == null)
            {
                return NotFound();
            }

            return View(songModel);
        }

        // GET: SongAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SongAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MId,Song,Author,Lyrics,Files,Photo,Nviews")] SongModel songModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(songModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(songModel);
        }

        // GET: SongAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songModel = await _context.SongModel.FindAsync(id);
            if (songModel == null)
            {
                return NotFound();
            }
            return View(songModel);
        }

        // POST: SongAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MId,Song,Author,Lyrics,Files,Photo,Nviews")] SongModel songModel)
        {
            if (id != songModel.MId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(songModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongModelExists(songModel.MId))
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
            return View(songModel);
        }

        // GET: SongAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songModel = await _context.SongModel
                .FirstOrDefaultAsync(m => m.MId == id);
            if (songModel == null)
            {
                return NotFound();
            }

            return View(songModel);
        }

        // POST: SongAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var songModel = await _context.SongModel.FindAsync(id);
            _context.SongModel.Remove(songModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongModelExists(int id)
        {
            return _context.SongModel.Any(e => e.MId == id);
        }
    }
}
