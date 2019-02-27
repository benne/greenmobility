namespace BenneIO.GreenMobility.Models
{
    public class VehicleModel
    {
        public VehicleModel(string energyType, string autonomyUnit, string name, int? id, int? seats, int? autonomy)
        {
            EnergyType = energyType;
            AutonomyUnit = autonomyUnit;
            Name = name;
            Id = id;
            Seats = seats;
            Autonomy = autonomy;
        }

        public string EnergyType { get; }

        public string AutonomyUnit { get; }

        public string Name { get; }

        public int? Id { get; }

        public int? Seats { get; }

        public int? Autonomy { get; }
    }
}