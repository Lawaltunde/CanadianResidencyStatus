using CanadianResidencyStatus.Models.Resident;

namespace CanadianResidencyStatus.Models.StatusInCanada
{
    public class StatusInCanadaDto 
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public DateTime StatusExpiringDate { get; set; }

        public List<ResidentDto> Residents { get; set; }
    }
}
