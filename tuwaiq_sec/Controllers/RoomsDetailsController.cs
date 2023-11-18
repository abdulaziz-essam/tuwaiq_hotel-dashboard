using Microsoft.AspNetCore.Mvc;
using tuwaiq_sec.Data;

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
        [Route("/RoomsDetails/Edit/{roomId}")]
        public IActionResult Edit(int id)
        {
            var roomDetail = _db.RoomDetail.Find(1);
            if (roomDetail == null)
            {
                return NotFound();
            }

            return View(roomDetail);
        }
    }
}
