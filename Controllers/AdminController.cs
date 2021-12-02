using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;
using App.Models.Bookings;
using System.Data.SqlTypes;

namespace App.Controllers
{
    // [Area("AdminManage")]

    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("/admin/")]

        public IActionResult AdminPage()
        {
            var dateNow = new SqlDateTime(DateTime.Now).ToSqlString();

            var bookingList = _context.Bookings.ToList();
            ViewBag.branch1 = _context.Bookings.Where(b => b.Branch == "nang rooftop").Count();
            ViewBag.branch2 = _context.Bookings.Where(b => b.Branch == "2pm").Count();
            ViewBag.branch3 = _context.Bookings.Where(b => b.Branch == "sargon").Count();
            ViewBag.branch4 = _context.Bookings.Where(b => b.Branch == "khoi rooftop").Count();
            ViewBag.count = _context.Bookings.Count();

            return View(bookingList);
        }

        public IActionResult GetListBranch()
        {
            var ListBranch = _context.Branchs.ToList();
            return View(ListBranch);
        }




    }
}