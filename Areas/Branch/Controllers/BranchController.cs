using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Models;
using BranchModel = App.Models.Branchs.Branch;

namespace App.Areas.Branch.Controllers

{

    [Area("Branch")]

    public class BranchController : Controller
    {
        private readonly AppDbContext _context;

        public BranchController(AppDbContext context)
        {
            _context = context;

        }

        // GET: Branch
        [HttpGet("/admin/branch")]

        public async Task<IActionResult> Index()
        {
            return View(await _context.Branchs.ToListAsync());
        }

        // GET: Branch/Details/5
        [HttpGet("/admin/branch/details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.Branchs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // GET: Branch/Create
        [HttpGet("/admin/branch/create/")]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Branch/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/admin/branch/create/")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BranchName,SlotTable,Distance,CreateDate,Address")] BranchModel branch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branch);
        }

        // GET: Branch/Edit/5
        [HttpGet("/admin/branch/edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.Branchs.FindAsync(id);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }

        // POST: Branch/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/admin/branch/edit/{id}")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("Id,BranchName,SlotTable,Distance,CreateDate,Address")] BranchModel branch)
        {
            if (id != branch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchExists(branch.Id))
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
            return View(branch);
        }

        // GET: Branch/Delete/5
        [HttpGet("/admin/branch/delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.Branchs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // POST: Branch/Delete/5
        [HttpPost("/admin/branch/delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var branch = await _context.Branchs.FindAsync(id);
            _context.Branchs.Remove(branch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchExists(int id)
        {
            return _context.Branchs.Any(e => e.Id == id);
        }
    }
}
