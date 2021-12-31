using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMusic_Auth.Data;
using WebMusic_Auth.Models;

namespace WebMusic.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly MusicContext _context;

        public PlaylistController(MusicContext context)
        {
            _context = context;
        }

        // GET: Playlist
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlaylistModel.ToListAsync());
        }

        // GET: Playlist/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistModel = await _context.PlaylistModel
                .FirstOrDefaultAsync(m => m.PId == id);
            if (playlistModel == null)
            {
                return NotFound();
            }

            return View(playlistModel);
        }

        // GET: Playlist/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Playlist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,PName,PDate,PStatus")] PlaylistModel playlistModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playlistModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playlistModel);
        }

        // GET: Playlist/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistModel = await _context.PlaylistModel.FindAsync(id);
            if (playlistModel == null)
            {
                return NotFound();
            }
            return View(playlistModel);
        }

        // POST: Playlist/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,PName,PDate,PStatus")] PlaylistModel playlistModel)
        {
            if (id != playlistModel.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playlistModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaylistModelExists(playlistModel.PId))
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
            return View(playlistModel);
        }

        // GET: Playlist/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistModel = await _context.PlaylistModel
                .FirstOrDefaultAsync(m => m.PId == id);
            if (playlistModel == null)
            {
                return NotFound();
            }

            return View(playlistModel);
        }

        // POST: Playlist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playlistModel = await _context.PlaylistModel.FindAsync(id);
            _context.PlaylistModel.Remove(playlistModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaylistModelExists(int id)
        {
            return _context.PlaylistModel.Any(e => e.PId == id);
        }
    }
}
