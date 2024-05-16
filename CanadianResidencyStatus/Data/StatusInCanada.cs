namespace CanadianResidencyStatus.Data
{
    public class StatusInCanada
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public DateTime StatusExpiringDate { get; set; }

        public virtual List<Resident> Residents { get; set; }
    }
}