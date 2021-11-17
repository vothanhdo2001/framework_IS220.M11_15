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
    public class LoveDetailCommentController : Controller
    {
        private readonly MusicContext _context;

        public LoveDetailCommentController(MusicContext context)
        {
            _context = context;
        }

        // GET: LoveDetailComment
        public async Task<IActionResult> Index()
        {
            var musicContext = _context.LoveDetailCommentModel.Include(l => l.User);
            return View(await musicContext.ToListAsync());
        }

        // GET: LoveDetailComment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loveDetailCommentModel = await _context.LoveDetailCommentModel
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.UsId == id);
            if (loveDetailCommentModel == null)
            {
                return NotFound();
            }

            return View(loveDetailCommentModel);
        }

        // GET: LoveDetailComment/Create
        public IActionResult Create()
        {
            ViewData["CoId"] = new SelectList(_context.UsersModel, "UsId", "UsId");
            return View();
        }

        // POST: LoveDetailComment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsId,CoId")] LoveDetailCommentModel loveDetailCommentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loveDetailCommentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoId"] = new SelectList(_context.UsersModel, "UsId", "UsId", loveDetailCommentModel.CoId);
            return View(loveDetailCommentModel);
        }

        // GET: LoveDetailComment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loveDetailCommentModel = await _context.LoveDetailCommentModel.FindAsync(id);
            if (loveDetailCommentModel == null)
            {
                return NotFound();
            }
            ViewData["CoId"] = new SelectList(_context.UsersModel, "UsId", "UsId", loveDetailCommentModel.CoId);
            return View(loveDetailCommentModel);
        }

        // POST: LoveDetailComment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsId,CoId")] LoveDetailCommentModel loveDetailCommentModel)
        {
            if (id != loveDetailCommentModel.UsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loveDetailCommentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoveDetailCommentModelExists(loveDetailCommentModel.UsId))
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
            ViewData["CoId"] = new SelectList(_context.UsersModel, "UsId", "UsId", loveDetailCommentModel.CoId);
            return View(loveDetailCommentModel);
        }

        // GET: LoveDetailComment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loveDetailCommentModel = await _context.LoveDetailCommentModel
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.UsId == id);
            if (loveDetailCommentModel == null)
            {
                return NotFound();
            }

            return View(loveDetailCommentModel);
        }

        // POST: LoveDetailComment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loveDetailCommentModel = await _context.LoveDetailCommentModel.FindAsync(id);
            _context.LoveDetailCommentModel.Remove(loveDetailCommentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoveDetailCommentModelExists(int id)
        {
            return _context.LoveDetailCommentModel.Any(e => e.UsId == id);
        }
    }
}
