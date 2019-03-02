using System.Collections.Generic;

namespace BenneIO.GreenMobility
{
    public class HomeZoneGeometry
    {
        public HomeZoneGeometry(string type, IEnumerable<IEnumerable<IEnumerable<double>>> coordinates)
        {
            Type = type;
            Coordinates = coordinates;
        }

        public string Type { get; }

        public IEnumerable<IEnumerable<IEnumerable<double>>> Coordinates { get; }
    }
}