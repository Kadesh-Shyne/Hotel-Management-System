using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string? AuditedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TimeOfAudit { get; set; }
        public string? BookedBy { get; set; }   
        public string? ModifiedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateModified { get; set; }

    }
}
