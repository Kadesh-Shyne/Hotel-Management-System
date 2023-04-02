using Hotel_Management_Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class Employee: AuditableBaseEntity
    {
        public string? FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Character length can not exceed 50.")]
        public string? MiddleName { get; set; }
        [Required(ErrorMessage = "Patient Family name is required.")]
        [StringLength(50, ErrorMessage = "Character length can not exceed 50.")]
        public string? LastName { get; set; }

        //Contact Information(Address, Phone Number, Email) 
        [StringLength(3, ErrorMessage = "Maximum character length is 3.")]
        [Display(Name = "HouseNumner")]
        [Required(ErrorMessage = "Hosue Number is a required field.")]
        public string? AddressLine1 { get; set; }

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]
        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "Street Number is a required field.")]
        public string? AddressLine2 { get; set; }

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]
        [Required(ErrorMessage = "City is a required field.")]
        public string? City { get; set; }

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]
        [Required(ErrorMessage = "State is a required field.")]
        public string? State { get; set; }

        [Range(4, 8, ErrorMessage = "Mini. value is 4 digit and max. value 8.")]
        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal code is a required field.")]
        public int PostalCode { get; set; }

        [StringLength(50, ErrorMessage = "Maximum character length is 50.")]
        [Required(ErrorMessage = "Country is a required field.")]
        public string? Country { get; set; }

        [StringLength(11, ErrorMessage = "Maximum character length is 11.")]
        [Required(ErrorMessage = "Phone number is a required field.")]
        public string? PhoneNumber { get; set; }
        
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email address.")]
        [StringLength(20, ErrorMessage = "Email character length is 20.")]
        public string? EmailAddress { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Enter a valid password.")]
        [StringLength(20, ErrorMessage = "Email character length is 20.")]
        public string? Password { get; set; }
    }
}
