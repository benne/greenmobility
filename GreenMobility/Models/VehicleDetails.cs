using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class VehicleDetails
    {
        public VehicleDetails(string id, string plate, int? cityId, string name, int? modelId, IEnumerable<int> optionIds,
            string iconsUrl, string tokenIconsUrl, string model)
        {
            Id = id;
            Plate = plate;
            CityId = cityId;
            Name = name;
            ModelId = modelId;
            OptionIds = optionIds;
            IconsUrl = iconsUrl;
            TokenIconsUrl = tokenIconsUrl;
            Model = model;
        }

        public string Id { get; }

        public string Plate { get; }

        public int? CityId { get; }

        public string Name { get; }

        public int? ModelId { get; }

        public IEnumerable<int> OptionIds { get; }

        public string IconsUrl { get; }

        public string TokenIconsUrl { get; }

        public string Model { get; }
    }
}