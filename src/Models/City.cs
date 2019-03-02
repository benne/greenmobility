using System;
using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class City
    {
        public City(int? id, string name, string timeZone, string culture, Position position, int? radius, int? zoomLevel,
            int? vehiclesInService, IEnumerable<string> homezoneIds, IEnumerable<string> layerIds, string termsAndConditionsUrl,
            DateTime? termsAndConditionsUpdateDate, string phoneNumber)
        {
            Id = id;
            Name = name;
            TimeZone = timeZone;
            Culture = culture;
            Position = position;
            Radius = radius;
            ZoomLevel = zoomLevel;
            VehiclesInService = vehiclesInService;
            HomezoneIds = homezoneIds;
            LayerIds = layerIds;
            TermsAndConditionsUrl = termsAndConditionsUrl;
            TermsAndConditionsUpdateDate = termsAndConditionsUpdateDate;
            PhoneNumber = phoneNumber;
        }

        public int? Id { get; }

        public string Name { get; }

        public string TimeZone { get; }

        public string Culture { get; }

        public Position Position { get; }

        public int? Radius { get; }

        public int? ZoomLevel { get; }

        public int? VehiclesInService { get; }

        public IEnumerable<string> HomezoneIds { get; }

        public IEnumerable<string> LayerIds { get; }

        public string TermsAndConditionsUrl { get; }

        public DateTime? TermsAndConditionsUpdateDate { get; }

        public string PhoneNumber { get; }
    }
}