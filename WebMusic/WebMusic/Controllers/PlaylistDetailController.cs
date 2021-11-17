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
    public class PlaylistDetailController : Controller
    {
        private readonly MusicContext _context;

        public PlaylistDetailController(MusicContext context)
        {
            _context = context;
        }

        // GET: PlaylistDetail
        public async Task<IActionResult> Index()
        {
            var musicContext = _context.PlaylistDetailModel.Include(p => p.Playlist).Include(p => p.Song).Include(p => p.User);
            return View(await musicContext.ToListAsync());
        }

        // GET: PlaylistDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistDetailModel = await _context.PlaylistDetailModel
                .Include(p => p.Playlist)
                .Include(p => p.Song)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.MId == id);
            if (playlistDetailModel == null)
            {
                return NotFound();
            }

            return View(playlistDetailModel);
        }

        // GET: PlaylistDetail/Create
        public IActionResult Create()
        {
            ViewData["PId"] = new SelectList(_context.PlaylistModel, "PId", "PId");
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId");
            ViewData["UsId"] = new SelectList(_context.UsersModel, "UsId", "UsId");
            return View();
        }

        // POST: PlaylistDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsId,PId,MId")] PlaylistDetailModel playlistDetailModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playlistDetailModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PId"] = new SelectList(_context.PlaylistModel, "PId", "PId", playlistDetailModel.PId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", playlistDetailModel.MId);
            ViewData["UsId"] = new SelectList(_context.UsersModel, "UsId", "UsId", playlistDetailModel.UsId);
            return View(playlistDetailModel);
        }

        // GET: PlaylistDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistDetailModel = await _context.PlaylistDetailModel.FindAsync(id);
            if (playlistDetailModel == null)
            {
                return NotFound();
            }
            ViewData["PId"] = new SelectList(_context.PlaylistModel, "PId", "PId", playlistDetailModel.PId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", playlistDetailModel.MId);
            ViewData["UsId"] = new SelectList(_context.UsersModel, "UsId", "UsId", playlistDetailModel.UsId);
            return View(playlistDetailModel);
        }

        // POST: PlaylistDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsId,PId,MId")] PlaylistDetailModel playlistDetailModel)
        {
            if (id != playlistDetailModel.MId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playlistDetailModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaylistDetailModelExists(playlistDetailModel.MId))
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
            ViewData["PId"] = new SelectList(_context.PlaylistModel, "PId", "PId", playlistDetailModel.PId);
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", playlistDetailModel.MId);
            ViewData["UsId"] = new SelectList(_context.UsersModel, "UsId", "UsId", playlistDetailModel.UsId);
            return View(playlistDetailModel);
        }

        // GET: PlaylistDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistDetailModel = await _context.PlaylistDetailModel
                .Include(p => p.Playlist)
                .Include(p => p.Song)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.MId == id);
            if (playlistDetailModel == null)
            {
                return NotFound();
            }

            return View(playlistDetailModel);
        }

        // POST: PlaylistDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playlistDetailModel = await _context.PlaylistDetailModel.FindAsync(id);
            _context.PlaylistDetailModel.Remove(playlistDetailModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaylistDetailModelExists(int id)
        {
            return _context.PlaylistDetailModel.Any(e => e.MId == id);
        }
    }
}
