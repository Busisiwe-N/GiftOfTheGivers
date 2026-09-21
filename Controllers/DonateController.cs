using GiftOfTheGivers.Data;
using GiftOfTheGivers.Models;
using Microsoft.AspNetCore.Mvc;

namespace GiftOfTheGivers.Controllers
{
    public class DonateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Donate
        public IActionResult Index()
        {
            return View();
        }

        // POST: Donate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Donation donation)
        {
            if (ModelState.IsValid)
            {
                donation.DateSubmitted = DateTime.Now;

                _context.Donations.Add(donation);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] =
                    "Thank you for your generous donation!";

                return RedirectToAction("Index");
            }

            return View(donation);
        }
    }
}