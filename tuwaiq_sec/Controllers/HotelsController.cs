﻿using Microsoft.AspNetCore.Authorization;
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
        [Authorize] // Apply the [Authorize] attribute to the action
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
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var hotel = _db.Hotels.Find(id);
            if (hotel != null)
            {
                _db.Hotels.Remove(hotel);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var hotel = _db.Hotels.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }
        [HttpPost]
        public IActionResult Edit(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _db.Hotels.Update(hotel);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(hotel);
        }



    }
}
