namespace BenneIO.GreenMobility.Models
{
    public class HomeZone
    {
        public HomeZone(string id, HomeZoneZone zone)
        {
            Id = id;
            Zone = zone;
        }

        public string Id { get; }

        public HomeZoneZone Zone { get; }
    }
}