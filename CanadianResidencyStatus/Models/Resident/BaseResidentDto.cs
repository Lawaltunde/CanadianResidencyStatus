using System.ComponentModel.DataAnnotations;

namespace CanadianResidencyStatus.Models.Resident
{
    public abstract class BaseResidentDto
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string SIN { get; set; }
        public DateTime DateOfEntry { get; set; }
    }
}
