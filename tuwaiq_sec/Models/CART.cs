using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tuwaiq_sec.Models
{
    public class CART
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Hotels")]
        public int HotelId { get; set; }
        public Hotels Hotel { get; set; }

        [ForeignKey("Rooms")]
        public int RoomId { get; set; }
        public Rooms Room { get; set; }

        [ForeignKey("RoomDetails")]
        public int RoomDetailsId { get; set; }
        public RoomDetails RoomDetails { get; set; }

        public int Price { get; set; }


        public int UserId { get; set; }
      
    }
}