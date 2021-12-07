using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;
using Microsoft.AspNetCore.Authorization;
using App.Repository.IBookingRepository;
using App.Repository.IBooking;
using BookingModel = App.Models.Bookings.Booking;
namespace App.Controllers
{
    // [Area("AdminManage")]

    // [Area("User/userpage")]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private IBooking ibooking;
        private readonly AppDbContext _context;


        public UsersController(ILogger<UsersController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult UserPage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserPage([Bind("ClientSlot,BookingSlot,Branch,UserName,UserPhone")] BookingModel Booking)
        {
            if (ModelState.IsValid)
            {

                Booking.CreateDate = DateTime.Now;
                _context.Add(Booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SuccessBooking), new { id = Booking.Id });
            }
            return View(Booking);

        }

        [HttpGet("/Users/SuccessBooking/{id}")]
        public IActionResult SuccessBooking(int id)
        {
            var usBooking = _context.Bookings.Where(x => x.Id == id).FirstOrDefault();
            return View(usBooking);
        }

        // // GET: Booking/Create
        // [HttpGet("/Users/bookinguser/")]
        // [AllowAnonymous]
        // public IActionResult BookingUser()
        // {
        //     return View();
        // }

        // [HttpPost("/Users/bookinguser/")]
        // [AllowAnonymous]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> BookingUser([Bind("ClientSlot,BookingSlot,Branch,UserName,UserPhone")] BookingModel Booking)
        // {
        //     if (ModelState.IsValid)
        //     {

        //         Booking.CreateDate = DateTime.Now;
        //         _context.Add(Booking);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(SuccessBooking), new { id = Booking.Id });
        //     }
        //     return View(Booking);

        // }

    }
}