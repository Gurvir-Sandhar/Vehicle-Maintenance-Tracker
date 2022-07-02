namespace VehicleMaintenanceTracker.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int Mileage { get; set; }
        public string WorkDone { get; set; }
        public DateTime CreatedDate { get; set; }

        public Record()
        {

        }

    }
}
