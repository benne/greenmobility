namespace BenneIO.GreenMobility.Models
{
    public class LocatedVehicle
    {
        public LocatedVehicle(VehicleStatus status, VehicleDetails description, Location location)
        {
            Status = status;
            Description = description;
            Location = location;
        }

        public VehicleStatus Status { get; }

        public VehicleDetails Description { get; }

        public Location Location { get; }
    }
}