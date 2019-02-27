namespace BenneIO.GreenMobility.Models
{
    public class VehicleStatus
    {
        public VehicleStatus(int? energyLevel)
        {
            EnergyLevel = energyLevel;
        }

        public int? EnergyLevel { get; }
    }
}