using Hotel_Management_Domain.Common;
using Hotel_Management_System.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Mgt_System.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(0, 10, ErrorMessage = "Mini. value is 4 digit and max. value 10.")]
        public int PaymentId { get; set; }
        [ForeignKey(nameof(CustomerDetails))]
        [Range(0, 10, ErrorMessage = "Mini. value is 0 digit and max. value 10.")]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(Bookings))]
        [Range(0, 10, ErrorMessage = "Mini. value is 0 digit and max. value 10.")]
        public int BookingId { get; set; }
        public string? FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Character length can not exceed 50.")]
        public string? MiddleName { get; set; }
        [Required(ErrorMessage = "Patient Family name is required.")]
        [StringLength(50, ErrorMessage = "Character length can not exceed 50.")]
        public string? LastName { get; set; }
        [StringLength(20, ErrorMessage = "Email character length is 15.")]
        public string? CreditCardNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
    }
}
