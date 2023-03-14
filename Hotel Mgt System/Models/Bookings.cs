using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_System.Models
{
    public class Bookings
    {
        [Key]
        [Required]
        public int BookingsId { get; set; }
        [ForeignKey(nameof(CustomerDetails))]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        
        public int NoOfNights { get; set; } 
    }
}
