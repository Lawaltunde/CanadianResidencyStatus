using System.ComponentModel.DataAnnotations;

namespace CanadianResidencyStatus.Models.Job
{
    public abstract class BaseJobDto
    {
        [Required]
        public string JobName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public Decimal Wages { get; set; }
        public DateTime DateOfEmployment { get; set; }

    }
}
