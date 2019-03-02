namespace BenneIO.GreenMobility.Models
{
    public class LayerFeature
    {
        public LayerFeature(string type, LayerProperties properties, LayerGeometry geometry)
        {
            Type = type;
            Properties = properties;
            Geometry = geometry;
        }

        public string Type { get; }

        public LayerProperties Properties { get; }

        public LayerGeometry Geometry { get; }
    }
}