using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace tuwaiq_sec.Models
{
    public class RoomDetail
    {
        [Key]
        public int Id { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

     
      
        public Room Room { get; set; }
        public int? RoomId { get; set; }

        public int FoodId { get; set; }
        public string Food { get; set; }

 
 
      
        public int HotelId { get; set; }
    }
}