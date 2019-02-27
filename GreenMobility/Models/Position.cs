namespace BenneIO.GreenMobility.Models
{
    public class Position
    {
        public Position(double lat, double lon)
        {
            Lat = lat;
            Lon = lon;
        }

        public double Lat { get; }

        public double Lon { get; }
    }
}