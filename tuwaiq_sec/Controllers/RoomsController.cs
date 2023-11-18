using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using tuwaiq_sec.Data;
using tuwaiq_sec.Models;

namespace tuwaiq_sec.Controllers
{
    public class RoomsController : Controller {

        private readonly AppDbContext _db;

        public RoomsController(AppDbContext db)
        {
            _db = db;
        }
        // GET /hotels
        [HttpGet]
        [Route("/Rooms/{hotelId}")]

        public IActionResult Index(int hotelId)
        {
            var rooms = _db.Rooms.Where(r => r.Hotelid == hotelId).ToList();

            return View(rooms);
        }


        public IActionResult Edit(int id)
        {
            var room = _db.Rooms.Find(id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }
        [HttpPost]
        public IActionResult Edit(Room room)
        {
            if (ModelState.IsValid)
            {
                _db.Rooms.Update(room);
                _db.SaveChanges();

                return RedirectToAction("Index", new { hotelId = room.Hotelid });
            }

            return View(room);
        }





    }
}
