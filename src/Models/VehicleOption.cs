namespace BenneIO.GreenMobility.Models
{
    public class VehicleOption
    {
        public VehicleOption(int? id, string name, string description, string iconsUrl, string tokenIconsUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            IconsUrl = iconsUrl;
            TokenIconsUrl = tokenIconsUrl;
        }

        public int? Id { get; }

        public string Name { get; }

        public string Description { get; }

        public string IconsUrl { get; }

        public string TokenIconsUrl { get; }
    }
}