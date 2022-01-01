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
    public class SingerAdminController : Controller
    {
        private readonly MusicContext _context;

        public SingerAdminController(MusicContext context)
        {
            _context = context;
        }

        // GET: SingerAdmin
        public async Task<IActionResult> Index()
        {
            return View(await _context.SingerModel.ToListAsync());
        }

        // GET: SingerAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singerModel = await _context.SingerModel
                .FirstOrDefaultAsync(m => m.SiId == id);
            if (singerModel == null)
            {
                return NotFound();
            }

            return View(singerModel);
        }

        // GET: SingerAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SingerAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SiId,SiName,Photo,Story")] SingerModel singerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(singerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(singerModel);
        }

        // GET: SingerAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singerModel = await _context.SingerModel.FindAsync(id);
            if (singerModel == null)
            {
                return NotFound();
            }
            return View(singerModel);
        }

        // POST: SingerAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SiId,SiName,Photo,Story")] SingerModel singerModel)
        {
            if (id != singerModel.SiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(singerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SingerModelExists(singerModel.SiId))
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
            return View(singerModel);
        }

        // GET: SingerAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singerModel = await _context.SingerModel
                .FirstOrDefaultAsync(m => m.SiId == id);
            if (singerModel == null)
            {
                return NotFound();
            }

            return View(singerModel);
        }

        // POST: SingerAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var singerModel = await _context.SingerModel.FindAsync(id);
            _context.SingerModel.Remove(singerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SingerModelExists(int id)
        {
            return _context.SingerModel.Any(e => e.SiId == id);
        }
    }
}
