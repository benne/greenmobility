namespace BenneIO.GreenMobility
{
    public class HomeZoneFeature
    {
        public HomeZoneFeature(string type, HomeZoneProperties properties, HomeZoneGeometry geometry)
        {
            Type = type;
            Properties = properties;
            Geometry = geometry;
        }

        public string Type { get; }

        public HomeZoneProperties Properties { get; }

        public HomeZoneGeometry Geometry { get; }
    }
}