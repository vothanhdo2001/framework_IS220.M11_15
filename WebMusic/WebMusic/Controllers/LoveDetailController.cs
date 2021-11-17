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
    public class LoveDetailController : Controller
    {
        private readonly MusicContext _context;

        public LoveDetailController(MusicContext context)
        {
            _context = context;
        }

        // GET: LoveDetail
        public async Task<IActionResult> Index()
        {
            var musicContext = _context.LoveDetailModel.Include(l => l.User);
            return View(await musicContext.ToListAsync());
        }

        // GET: LoveDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loveDetailModel = await _context.LoveDetailModel
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.UsId == id);
            if (loveDetailModel == null)
            {
                return NotFound();
            }

            return View(loveDetailModel);
        }

        // GET: LoveDetail/Create
        public IActionResult Create()
        {
            ViewData["MId"] = new SelectList(_context.UsersModel, "UsId", "UsId");
            return View();
        }

        // POST: LoveDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsId,MId")] LoveDetailModel loveDetailModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loveDetailModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MId"] = new SelectList(_context.UsersModel, "UsId", "UsId", loveDetailModel.MId);
            return View(loveDetailModel);
        }

        // GET: LoveDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loveDetailModel = await _context.LoveDetailModel.FindAsync(id);
            if (loveDetailModel == null)
            {
                return NotFound();
            }
            ViewData["MId"] = new SelectList(_context.UsersModel, "UsId", "UsId", loveDetailModel.MId);
            return View(loveDetailModel);
        }

        // POST: LoveDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsId,MId")] LoveDetailModel loveDetailModel)
        {
            if (id != loveDetailModel.UsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loveDetailModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoveDetailModelExists(loveDetailModel.UsId))
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
            ViewData["MId"] = new SelectList(_context.UsersModel, "UsId", "UsId", loveDetailModel.MId);
            return View(loveDetailModel);
        }

        // GET: LoveDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loveDetailModel = await _context.LoveDetailModel
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.UsId == id);
            if (loveDetailModel == null)
            {
                return NotFound();
            }

            return View(loveDetailModel);
        }

        // POST: LoveDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loveDetailModel = await _context.LoveDetailModel.FindAsync(id);
            _context.LoveDetailModel.Remove(loveDetailModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoveDetailModelExists(int id)
        {
            return _context.LoveDetailModel.Any(e => e.UsId == id);
        }
    }
}
