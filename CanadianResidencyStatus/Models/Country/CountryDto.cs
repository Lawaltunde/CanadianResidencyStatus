using CanadianResidencyStatus.Data;
using CanadianResidencyStatus.Models.Resident;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanadianResidencyStatus.Models.Country
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<ResidentDto> Residents { get; set; } 
    }

   
}
