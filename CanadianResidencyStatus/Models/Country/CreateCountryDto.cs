using System.ComponentModel.DataAnnotations;

namespace CanadianResidencyStatus.Models.Country
{
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
