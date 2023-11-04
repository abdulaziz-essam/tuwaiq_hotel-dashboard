using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tuwaiq_sec.Models
{
    public class RoomDetails
    {
        [Key]
        public int Id { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        [ForeignKey("Rooms")]
        public int RoomId { get; set; }
        public Rooms Room { get; set; }

  
        public int FoodId { get; set; }
        public string Food { get; set; }

        [ForeignKey("Hotels")]
        public int HotelId { get; set; }
        public Hotels Hotel { get; set; }
    }
}