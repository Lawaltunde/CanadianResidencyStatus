
using System.ComponentModel.DataAnnotations.Schema;

namespace CanadianResidencyStatus.Data
{
    public class Resident
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string SIN { get; set; }
        public DateTime DateOfEntry { get; set; }

        //Country Entity
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country country { get; set; }

        //Job Entity
        [ForeignKey(nameof(JobId))]
        public int JobId { get; set; }
        public Job job { get; set; }

        //Status Entity
        [ForeignKey(nameof(StatusId))]
        public int StatusId { get; set; }
        public StatusInCanada status { get; set; }
    }
}
