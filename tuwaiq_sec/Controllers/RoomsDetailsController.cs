using Microsoft.AspNetCore.Mvc;
using tuwaiq_sec.Data;
using tuwaiq_sec.Models;

namespace tuwaiq_sec.Controllers
{
    public class RoomsDetailsController : Controller
    {
        private readonly AppDbContext _db;

        public RoomsDetailsController(AppDbContext db)
        {
            _db = db;
        }
     
        [HttpGet]
        [Route("/RoomsDetails/{roomId}")]
        public IActionResult Index(int roomId)
        {
            var roomDetail = _db.RoomDetail.FirstOrDefault(rd => rd.RoomId == roomId);
            if (roomDetail == null)
            {
                return NotFound();
            }


            return View(roomDetail);
        }
        [HttpGet]
        [Route("/RoomDetails/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RoomDetail room)
        {
            if (ModelState.IsValid)
            {
                // Save the new hotel to the database
                _db.RoomDetail.Add(room);
                _db.SaveChanges();

                return RedirectToAction("Index", new { roomId = room.RoomId });
            }

            return View(room);
        }



    }
}
