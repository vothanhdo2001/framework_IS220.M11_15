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
    public class AlbumController : Controller
    {
        private readonly MusicContext _context;

        public AlbumController(MusicContext context)
        {
            _context = context;
        }

        // GET: Album
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlbumModel.ToListAsync());
        }

        // GET: Album/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumModel = await _context.AlbumModel
                .FirstOrDefaultAsync(m => m.AId == id);
            if (albumModel == null)
            {
                return NotFound();
            }

            return View(albumModel);
        }

        // GET: Album/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Album/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AId,AName,ADate,SName,Intro,Photo,AStatus")] AlbumModel albumModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albumModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(albumModel);
        }

        // GET: Album/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumModel = await _context.AlbumModel.FindAsync(id);
            if (albumModel == null)
            {
                return NotFound();
            }
            return View(albumModel);
        }

        // POST: Album/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AId,AName,ADate,SName,Intro,Photo,AStatus")] AlbumModel albumModel)
        {
            if (id != albumModel.AId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(albumModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumModelExists(albumModel.AId))
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
            return View(albumModel);
        }

        // GET: Album/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albumModel = await _context.AlbumModel
                .FirstOrDefaultAsync(m => m.AId == id);
            if (albumModel == null)
            {
                return NotFound();
            }

            return View(albumModel);
        }

        // POST: Album/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var albumModel = await _context.AlbumModel.FindAsync(id);
            _context.AlbumModel.Remove(albumModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumModelExists(int id)
        {
            return _context.AlbumModel.Any(e => e.AId == id);
        }
    }
}
