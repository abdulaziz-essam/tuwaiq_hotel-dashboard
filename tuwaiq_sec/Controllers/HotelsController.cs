using Microsoft.AspNetCore.Mvc;
using tuwaiq_sec.Data;
using tuwaiq_sec.Models;

namespace tuwaiq_sec.Controllers
{
    public class HotelsController : Controller
    {
        private readonly AppDbContext _db;

        public HotelsController(AppDbContext db)
        {
            _db = db;
        }

        // GET /hotels

        public IActionResult Index()
        {
            var hotels = _db.Hotels.ToList();
            return View(hotels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                // Save the new hotel to the database
                _db.Hotels.Add(hotel);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(hotel);
        }
    }
}