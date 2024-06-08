using CanadianResidencyStatus.Models.Resident;

namespace CanadianResidencyStatus.Models.Job
{
    public class JobDto
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public Decimal Wages { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public List<ResidentDto> Residents {  get; set; } 
    }
}
