using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tuwaiq_sec.Models; // Add this using directive to resolve the missing types

namespace tuwaiq_sec.Models
{
    public class CART
    {
        [Key]
        public int Id { get; set; }

  
        public int HotelId { get; set; }


  
        public int RoomId { get; set; }
    

    
        public int RoomDetailId { get; set; }


        public int Price { get; set; }

        public int UserId { get; set; }
    }
}