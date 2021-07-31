using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;

namespace Controllers {
    public class CarRentController : Controller {
        private readonly Context _context;
        public CarRentController(Context context) {
            _context = context;
        }
        public async Task<IActionResult> Index() {
            return View(await _context.CarRent.ToListAsync());
        }

        [HttpGet]
        public IActionResult NewCarRent() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewCarRent(CarRent carRent) {
            await _context.CarRent.AddAsync(carRent);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


    }
}
