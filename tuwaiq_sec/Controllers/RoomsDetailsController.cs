using Microsoft.AspNetCore.Mvc;
using tuwaiq_sec.Data;
using tuwaiq_sec.Models;

namespace tuwaiq_sec.Controllers
{
    public class RoomDetailsController : Controller
    {
        private readonly AppDbContext _db;

        public RoomDetailsController(AppDbContext db)
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
                return RedirectToAction("Create");
            }


            return View(roomDetail);
        }

        // GET: /RoomDetails/Create
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        // POST: /RoomDetails/Create
        [HttpPost]

        public IActionResult Create(RoomDetail roomDetail)
        {
            if (ModelState.IsValid)
            {
                _db.RoomDetail.Add(roomDetail);
                _db.SaveChanges();

                return RedirectToAction("Index", "Rooms", new { hotelId = roomDetail.HotelId });
            }

            return View(roomDetail);
        }
    }
}