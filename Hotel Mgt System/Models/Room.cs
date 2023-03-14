using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }      
        public string? RoomType { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public int HotelId { get; set; }    
    }
}
