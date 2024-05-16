namespace CanadianResidencyStatus.Data
{
    public class Job
    {
        public int Id {  get; set; }
        public string JobName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public Decimal Wages { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public virtual List<Resident> Residents { get; set; }

    }
}