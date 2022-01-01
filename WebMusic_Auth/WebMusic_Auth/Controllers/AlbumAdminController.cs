using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMusic_Auth.Data;
using WebMusic_Auth.Models;

namespace WebMusic_Auth.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AlbumAdminController : Controller
    {
        private readonly MusicContext _context;

        public AlbumAdminController(MusicContext context)
        {
            _context = context;
        }

        // GET: AlbumAdmin
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlbumModel.ToListAsync());
        }

        // GET: AlbumAdmin/Details/5
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

        // GET: AlbumAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlbumAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AId,AName,Intro,Photo")] AlbumModel albumModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(albumModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(albumModel);
        }

        // GET: AlbumAdmin/Edit/5
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

        // POST: AlbumAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AId,AName,Intro,Photo")] AlbumModel albumModel)
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

        // GET: AlbumAdmin/Delete/5
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

        // POST: AlbumAdmin/Delete/5
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
