using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class LayerContent
    {
        public LayerContent(string type, IEnumerable<LayerFeature> features)
        {
            Type = type;
            Features = features;
        }

        public string Type { get; }

        public IEnumerable<LayerFeature> Features { get; }
    }
}