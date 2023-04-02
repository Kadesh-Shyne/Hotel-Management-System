using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_System.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int RoomId { get; set; }
        [StringLength(10, ErrorMessage = "Character length can not exceed 10.")]
        public string? RoomType { get; set; }
        [StringLength(10, ErrorMessage = "Character length can not exceed 10.")]
        public string? Image { get; set; }
        [StringLength(50, ErrorMessage = "Character length can not exceed 50.")]
        public string? Description { get; set; }
        [Range(0, 10, ErrorMessage = "Mini. value is 0 digit and max. value 10.")]
        public int HotelId { get; set; }    
    }
}
