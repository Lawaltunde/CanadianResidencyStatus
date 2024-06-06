namespace CanadianResidencyStatus.Models.Resident
{
    public class ResidentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string SIN { get; set; }
        public DateTime DateOfEntry { get; set; }

        public int CountryId { get; set; }

        public int JobId { get; set; }

        public int StatusId { get; set; }
    }
}
