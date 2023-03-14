using Hotel_Management_Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_System.Models
{
    public class Bookings: AuditableBaseEntity
    {      
        [ForeignKey(nameof(CustomerDetails))]
        [Range(0, 10, ErrorMessage = "Mini. value is 0 digit and max. value 10.")]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(Room))]
        [Range(0, 10, ErrorMessage = "Mini. value is 0 digit and max. value 10.")]
        public int RoomId { get; set; }
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [Range(0, 10, ErrorMessage = "Mini. value is 0 digit and max. value 10.")]
        public int NoOfNights { get; set; } 
    }
}
