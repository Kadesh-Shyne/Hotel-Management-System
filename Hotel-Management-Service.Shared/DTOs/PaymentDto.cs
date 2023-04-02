using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_Service.Shared.DTOs
{
    public class PaymentDto
    {
        [Key]
        public int PaymentId { get; set; }
        [ForeignKey(nameof(CustomerDetailsDto))]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(BookingsDto))]
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
