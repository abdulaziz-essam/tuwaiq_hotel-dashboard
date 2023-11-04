namespace tuwaiq_sec.Models
{
    using System.ComponentModel.DataAnnotations;


    public class Hotels
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Images { get; set; }
    }
}
    
