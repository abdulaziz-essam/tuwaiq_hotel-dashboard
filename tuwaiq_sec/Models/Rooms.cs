using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tuwaiq_sec.Models
{
    public class Rooms
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Futures { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string RoomNo { get; set; }

        [ForeignKey("Hotels")]
        public int HotelId { get; set; }
        public Hotels Hotel { get; set; }
    }
}