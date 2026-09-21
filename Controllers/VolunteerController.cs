using GiftOfTheGivers.Data;
using GiftOfTheGivers.Models;
using Microsoft.AspNetCore.Mvc;

namespace GiftOfTheGivers.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VolunteerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(VolunteerApplication application)
        {
            if (ModelState.IsValid)
            {
                application.DateSubmitted = DateTime.Now;

                _context.VolunteerApplications.Add(application);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] =
                    "Thank you! Your volunteer application has been submitted successfully.";

                return RedirectToAction("Index");
            }

            return View(application);
        }
    }
}