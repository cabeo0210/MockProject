using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;

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
            var bookingList = _context.Bookings.ToList();
            return View(bookingList);
        }

        public IActionResult GetListBranch()
        {
            var ListBranch = _context.Branchs.ToList();
            return View(ListBranch);
        }


    }
}