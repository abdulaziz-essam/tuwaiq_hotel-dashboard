using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tuwaiq_sec.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }


  


        public decimal Price { get; set; }

       
        public string Image { get; set; }


        public string RoomNo { get; set; }



        public int Hotelid { get; set; }

    }
}