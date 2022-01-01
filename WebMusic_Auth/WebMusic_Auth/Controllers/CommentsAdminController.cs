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
    public class CommentsAdminController : Controller
    {
        
        private readonly MusicContext _context;

        public CommentsAdminController(MusicContext context)
        {
            _context = context;
        }

        // GET: CommentsAdmin
        public async Task<IActionResult> Index()
        {
            var musicContext = _context.CommentsModel.Include(c => c.Song).Include(c => c.User);
            return View(await musicContext.ToListAsync());
        }

        // GET: CommentsAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentsModel = await _context.CommentsModel
                .Include(c => c.Song)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CoId == id);
            if (commentsModel == null)
            {
                return NotFound();
            }

            return View(commentsModel);
        }

        // GET: CommentsAdmin/Create
        public IActionResult Create()
        {
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId");
            ViewData["UsId"] = new SelectList(_context.Set<AppUser>(), "Id", "Id");
            return View();
        }

        // POST: CommentsAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoId,UsId,MId,Content,CoStatus")] CommentsModel commentsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commentsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", commentsModel.MId);
            ViewData["UsId"] = new SelectList(_context.Set<AppUser>(), "Id", "Id", commentsModel.UsId);
            return View(commentsModel);
        }

        // GET: CommentsAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentsModel = await _context.CommentsModel.FindAsync(id);
            if (commentsModel == null)
            {
                return NotFound();
            }
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", commentsModel.MId);
            ViewData["UsId"] = new SelectList(_context.Set<AppUser>(), "Id", "Id", commentsModel.UsId);
            return View(commentsModel);
        }

        // POST: CommentsAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CoId,UsId,MId,Content,CoStatus")] CommentsModel commentsModel)
        {
            if (id != commentsModel.CoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commentsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentsModelExists(commentsModel.CoId))
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
            ViewData["MId"] = new SelectList(_context.SongModel, "MId", "MId", commentsModel.MId);
            ViewData["UsId"] = new SelectList(_context.Set<AppUser>(), "Id", "Id", commentsModel.UsId);
            return View(commentsModel);
        }

        // GET: CommentsAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentsModel = await _context.CommentsModel
                .Include(c => c.Song)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CoId == id);
            if (commentsModel == null)
            {
                return NotFound();
            }

            return View(commentsModel);
        }

        // POST: CommentsAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commentsModel = await _context.CommentsModel.FindAsync(id);
            _context.CommentsModel.Remove(commentsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentsModelExists(int id)
        {
            return _context.CommentsModel.Any(e => e.CoId == id);
        }
    }
}
