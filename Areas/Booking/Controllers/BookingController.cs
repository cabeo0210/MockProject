using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Models;
using BookingModel = App.Models.Bookings.Booking;

namespace App.Areas.Booking.Controllers

{

    [Area("Booking")]

    public class BookingController : Controller
    {
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;

        }

        // GET: Booking
        [HttpGet("/admin/Booking")]

        public async Task<IActionResult> Index()
        {
            return View(await _context.Bookings.ToListAsync());
        }

        // GET: Booking/Details/5
        [HttpGet("/admin/Booking/details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Booking == null)
            {
                return NotFound();
            }

            return View(Booking);
        }

        // GET: Booking/Create
        [HttpGet("/admin/Booking/create/")]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/admin/Booking/create/")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientSlot,BookingSlot,Branch,UserName,UserPhone")] BookingModel Booking)
        {
            if (ModelState.IsValid)
            {
                Booking.CreateDate = DateTime.Now;
                _context.Add(Booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Booking);
        }

        // GET: Booking/Edit/5
        [HttpGet("/admin/Booking/edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Booking = await _context.Bookings.FindAsync(id);
            if (Booking == null)
            {
                return NotFound();
            }
            return View(Booking);
        }

        // POST: Booking/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/admin/Booking/edit/{id}")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("ClientSlot,BookingSlot,Branch,UserName,UserPhone")] BookingModel Booking)
        {
            if (id != Booking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Booking.CreateDate = DateTime.Now;
                    _context.Update(Booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(Booking.Id))
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
            return View(Booking);
        }

        // GET: Booking/Delete/5
        [HttpGet("/admin/Booking/delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Booking == null)
            {
                return NotFound();
            }

            return View(Booking);
        }

        // POST: Booking/Delete/5
        [HttpPost("/admin/Booking/delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(Booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
