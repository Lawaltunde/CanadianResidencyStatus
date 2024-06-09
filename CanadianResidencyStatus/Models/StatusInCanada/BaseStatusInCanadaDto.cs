using System.ComponentModel.DataAnnotations;

namespace CanadianResidencyStatus.Models.StatusInCanada
{
    public abstract class BaseStatusInCanadaDto
    {
        [Required]
        public string StatusName { get; set; }
        public DateTime StatusExpiringDate { get; set; }
    }
}
