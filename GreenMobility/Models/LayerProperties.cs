namespace BenneIO.GreenMobility.Models
{
    public class LayerProperties
    {
        public LayerProperties(string type, string name, string description)
        {
            Type = type;
            Name = name;
            Description = description;
        }

        public string Type { get; }

        public string Name { get; }

        public string Description { get; }
    }
}