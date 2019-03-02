using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class LayerGeometry
    {
        public LayerGeometry(string type, IEnumerable<double> coordinates)
        {
            Type = type;
            Coordinates = coordinates;
        }

        public string Type { get; }

        public IEnumerable<double> Coordinates { get; }
    }
}