﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tuwaiq_sec.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        public int HotelId { get; set; }
   

    
        public int RoomId { get; set; }
     
        public int RoomDetailsId { get; set; }


        public DateTime Date { get; set; }

        public double Price { get; set; }

 
        public int UserId { get; set; }
    

        public double Tax { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public double Net { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}