using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class HomeZoneZone
    {
        public HomeZoneZone(string type, IEnumerable<HomeZoneFeature> features)
        {
            Type = type;
            Features = features;
        }

        public string Type { get; }

        public IEnumerable<HomeZoneFeature> Features { get; }
    }
}